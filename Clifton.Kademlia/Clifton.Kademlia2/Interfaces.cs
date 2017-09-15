﻿using System.Collections.Generic;

namespace Clifton.Kademlia
{
    public interface IProtocol
    {
        List<Contact> FindNode(Contact sender, ID key);
        (List<Contact> contacts, string val) FindValue(Contact sender, ID key);
        void Store(Contact sender, ID key, string val);
    }

    public interface IStorage
    {
        bool Contains(ID key);
        bool TryGetValue(ID key, out string val);
        string Get(ID key);
        void Set(ID key, string value);
    }
}
