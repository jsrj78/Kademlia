using System.Numerics;

using Clifton.Kademlia.Common;

namespace Clifton.Kademlia
{
    public class ContactEventArgs
    {
        public Contact Contact { get; set; }
    }

    public class StoreEventArgs
    {
        public BigInteger Key { get; set; }
    }
}
