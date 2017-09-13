﻿using System;
using System.Linq;
using System.Numerics;

namespace Clifton.Kademlia
{
    public class ID
    {
#if DEBUG       // For unit testing.
        public BigInteger Value { get { return id; } }
#endif

		// Zero-pad msb's if ToByteArray length != Constants.LENGTH_BYTES
		// The array returned is in little-endian order (lsb at index 0)
		public byte[] Bytes
		{
			get
			{
				byte[] bytes = new byte[Constants.ID_LENGTH_BYTES];
				byte[] partial = id.ToByteArray().Take(Constants.ID_LENGTH_BYTES).ToArray();    // remove msb 0 at index 20.
				partial.CopyTo(bytes, 0);

				return bytes;
			}
		}

        public string AsBigEndianString
        {
            get { return String.Join("", Bytes.Bits().Reverse().Select(b => b ? "1" : "0")); } }

		/// <summary>
		/// Produce a random ID distributed evenly across the 160 bit space.
		/// </summary>
		public static ID RandomID
		{
			get
			{
				byte[] data = new byte[Constants.ID_LENGTH_BYTES];
				ID id = new ID(data);
				// Uniform random bucket index.
				int idx = rnd.Next(Constants.ID_LENGTH_BITS);
				// 0 <= idx <= 159
				// Remaining bits are randomized to get unique ID.
				id.SetBit(idx);
				id = id.RandomizeBeyond(idx);

				return id;
			}
		}

		protected BigInteger id;
		private static Random rnd = new Random();

		/// <summary>
		/// Construct the ID from a byte array.
		/// </summary>
		public ID(byte[] data)
        {
            IDInit(data);
        }

        /// <summary>
        /// Construct the ID from another BigInteger value.
        /// </summary>
        public ID(BigInteger bi)
        {
            id = bi;
        }

		/// <summary>
		/// Initialize the ID from a byte array, appending a 0 to force unsigned values.
		/// </summary>
		protected void IDInit(byte[] data)
        {
            Validate.IsTrue<IDLengthException>(data.Length == Constants.ID_LENGTH_BYTES, "ID must be " + Constants.ID_LENGTH_BYTES + " bytes in length.");
            id = new BigInteger(data.Append0());
        }

		protected ID RandomizeBeyond(int bit)
		{
			byte[] randomized = Bytes;

			ID newid = new ID(randomized);

			// TODO: Optimize
			for (int i = bit + 1; i < Constants.ID_LENGTH_BITS; i++)
			{
				newid.ClearBit(i);
			}

			// TODO: Optimize
			for (int i = 0; i < bit; i++)
			{
				if (rnd.NextDouble() < 0.5)
				{
					newid.SetBit(i);
				}
			}

			return newid;
		}

		/// <summary>
		/// Clears the bit n, from the LSB.
		/// </summary>
		public void ClearBit(int n)
		{
			byte[] bytes = Bytes;
			bytes[n / 8] &= (byte)((1 << (n % 8)) ^ 0xFF);
			id = new BigInteger(bytes.Append0());
		}

		/// <summary>
		/// Sets the bit n, from the LSB.
		/// </summary>
		public void SetBit(int n)
		{
			byte[] bytes = Bytes;
			bytes[n / 8] |= (byte)(1 << (n % 8));
			id = new BigInteger(bytes.Append0());
		}
	}
}