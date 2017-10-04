using System;
using System.Collections.Generic;
using System.Numerics;

using DBreeze;
using Newtonsoft.Json;

using Clifton.Kademlia.Common;

namespace Clifton.Kademlia.Store.DBreeze
{
    public class DBreezeStore : IStorage, IDisposable
    {
        public bool HasValues => throw new NotImplementedException();
        public List<BigInteger> Keys => throw new NotImplementedException();

        protected DBreezeEngine db;
        protected bool disposed = false;
        protected const string TABLE_NAME = "Kademlia";

        public DBreezeStore(string fn)
        {
            db = new DBreezeEngine(fn);
        }

        public bool Contains(ID key)
        {
            bool exists = false;

            using (var tran = db.GetTransaction())
            {
                exists = tran.Select<string, string>(TABLE_NAME, key.ToString()).Exists;
            }

            return exists;
        }

        public string Get(ID key)
        {
            return Get(key.Value);
        }

        public string Get(BigInteger key)
        {
            string json = GetJson(key);

            return JsonConvert.DeserializeObject<StoreValue>(json).Value;
        }

        public int GetExpirationTimeSec(BigInteger key)
        {
            string json = GetJson(key);

            return JsonConvert.DeserializeObject<StoreValue>(json).ExpirationTime;
        }

        public DateTime GetTimeStamp(BigInteger key)
        {
            string json = GetJson(key);

            return JsonConvert.DeserializeObject<StoreValue>(json).RepublishTimeStamp;
        }

        public void Remove(BigInteger key)
        {
            using (var tran = db.GetTransaction())
            {
                tran.RemoveKey(TABLE_NAME, key.ToString());
                tran.Commit();
            }
        }

        public void Set(ID key, string value, int expirationTimeSec = 0)
        {
            using (var tran = db.GetTransaction())
            {
                tran.Insert(TABLE_NAME, key.ToString(),
                    JsonConvert.SerializeObject(new StoreValue
                    {
                        Value = value,
                        ExpirationTime = expirationTimeSec,
                        RepublishTimeStamp = DateTime.Now,
                    }));
                tran.Commit();
            }
        }

        public void Touch(BigInteger key)
        {
            string json = GetJson(key);
            var store = JsonConvert.DeserializeObject<StoreValue>(json);
            store.RepublishTimeStamp = DateTime.Now;

            using (var tran = db.GetTransaction())
            {
                tran.Insert(TABLE_NAME, key.ToString(), JsonConvert.SerializeObject(store));
                tran.Commit();
            }
        }

        public bool TryGetValue(ID key, out string val)
        {
            bool ret = false;
            val = null;
            string json = GetJson(key.Value);

            if (json != null)
            {
                ret = true;
                val = JsonConvert.DeserializeObject<StoreValue>(json).Value;
            }

            return ret;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected string GetJson(BigInteger key)
        {
            string json = null;

            using (var tran = db.GetTransaction())
            {
                json = tran.Select<string, string>(TABLE_NAME, key.ToString()).Value;
            }

            return json;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }

            disposed = true;
        }
    }
}
