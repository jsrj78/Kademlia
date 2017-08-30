﻿using System;
using System.Collections.Generic;

namespace Clifton.Kademlia
{
	public class Node
	{
		// TODO: Create read-only version of these or otherwise rework to avoid getters that can change the contents.
		public Contact OurContact { get; }
		public BucketList BucketList { get { return bucketList; } }

		protected BucketList bucketList;
		protected IStorage storage;

		protected Node()
		{
			bucketList = new BucketList();
		}

		public Node(Contact us) : this()
		{
			OurContact = us;
		}

		public Node(IAddress address, ID nodeID) : this()
		{
			OurContact = new Contact() { Address = address, NodeID = nodeID };
		}

		public void SimpleRegistration(Contact sender)
		{
			bucketList.HaveContact(OurContact.NodeID, sender, (_) => false);
		}

		public Contact Ping(Contact sender)
		{
			SimpleRegistration(sender);

			return OurContact;
		}

		public void Store(Contact sender, string key, string val)
		{
			bucketList.HaveContact(OurContact.NodeID, sender, (_) => false);
			storage.Set(key, val);
		}

		/// <summary>
		/// From the spec: FindNode takes a 160-bit ID as an argument. The recipient of the RPC returns (IP address, UDP port, Node ID) triples 
		/// for the k nodes it knows about closest to the target ID. These triples can come from a single k-bucket, or they may come from 
		/// multiple k-buckets if the closest k-bucket is not full. In any case, the RPC recipient must return k items (unless there are 
		/// fewer than k nodes in all its k-buckets combined, in which case it returns every node it knows about).
		/// </summary>
		/// <returns></returns>
		public List<Contact> FindNode(Contact sender, ID toFind)
		{
			bucketList.HaveContact(OurContact.NodeID, sender, (_) => false);
			List<Contact> contacts = bucketList.GetCloseContacts(toFind, sender.NodeID);

			return contacts;
		}

		public (List<Contact> nodes, string val) FindValue(Contact sender, string key)
		{
			bucketList.HaveContact(OurContact.NodeID, sender, (_) => false);
			return (null, null);
		}
	}
}