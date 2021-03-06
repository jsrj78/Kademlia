﻿using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

using Clifton.Kademlia.Common;

namespace Clifton.Kademlia.Protocols
{
    // ==========================

    public class TcpProtocol : IProtocol
    {
#if DEBUG       // for unit tests
        public bool Responds { get; set; }
#endif

        // For serialization:
        public string Url { get { return url; } set { url = value; } }
        public int Port { get { return port; } set { port = value; } }
        [JsonIgnore]
        public int Subnet { get { throw new NotSupportedException("Subnet is not supported for TcpProtocol"); } }
        public string Description { get { return Url + ":" + Port; } }

        protected string url;
        protected int port;

        /// <summary>
        /// For serialization.
        /// </summary>
        public TcpProtocol()
        {
        }

        public TcpProtocol(string url, int port)
        {
            this.url = url;
            this.port = port;

#if DEBUG
            Responds = true;
#endif
        }

        public (List<Contact> contacts, RpcError error) FindNode(Contact sender, ID key)
        {
            ErrorResponse error;
            ID id = ID.RandomID;
            bool timeoutError;

            var ret = RestCall.Post<FindNodeResponse, ErrorResponse>(url + ":" + port + "//FindNode",
                new FindNodeSubnetRequest()
                {
                    Protocol = sender.Protocol,
                    ProtocolName = sender.Protocol.GetType().Name,
                    Sender = sender.ID.Value,
                    Key = key.Value,
                    RandomID = id.Value
                }, out error, out timeoutError);

            try
            {
                var contacts = ret?.Contacts?.Select(val => new Contact(Protocol.InstantiateProtocol(val.Protocol, val.ProtocolName), new ID(val.Contact))).ToList();

                // Return only contacts with supported protocols.
                return (contacts?.Where(c => c.Protocol != null).ToList() ?? EmptyContactList(), GetRpcError(id, ret, timeoutError, error));
            }
            catch (Exception ex)
            {
                return (null, new RpcError() { ProtocolError = true, ProtocolErrorMessage = ex.Message });
            }
        }

        /// <summary>
        /// Attempt to find the value in the peer network.
        /// </summary>
        /// <returns>A null contact list is acceptable here as it is a valid return if the value is found.
        /// The caller is responsible for checking the timeoutError flag to make sure null contacts is not
        /// the result of a timeout error.</returns>
        public (List<Contact> contacts, string val, RpcError error) FindValue(Contact sender, ID key)
        {
            ErrorResponse error;
            ID id = ID.RandomID;
            bool timeoutError;

            var ret = RestCall.Post<FindValueResponse, ErrorResponse>(url + ":" + port + "//FindValue",
                new FindValueSubnetRequest()
                {
                    Protocol = sender.Protocol,
                    ProtocolName = sender.Protocol.GetType().Name,
                    Sender = sender.ID.Value,
                    Key = key.Value,
                    RandomID = id.Value
                }, out error, out timeoutError);

            try
            {
                var contacts = ret?.Contacts?.Select(val => new Contact(Protocol.InstantiateProtocol(val.Protocol, val.ProtocolName), new ID(val.Contact))).ToList();

                // Return only contacts with supported protocols.
                return (contacts?.Where(c => c.Protocol != null).ToList(), ret.Value, GetRpcError(id, ret, timeoutError, error));
            }
            catch (Exception ex)
            {
                return (null, null, new RpcError() { ProtocolError = true, ProtocolErrorMessage = ex.Message });
            }
        }

        public RpcError Ping(Contact sender)
        {
            ErrorResponse error;
            ID id = ID.RandomID;
            bool timeoutError;

            var ret = RestCall.Post<FindValueResponse, ErrorResponse>(url + ":" + port + "//Ping",
                new PingSubnetRequest()
                {
                    Protocol = sender.Protocol,
                    ProtocolName = sender.Protocol.GetType().Name,
                    Sender = sender.ID.Value,
                    RandomID = id.Value
                }, 
                out error, out timeoutError);

            return GetRpcError(id, ret, timeoutError, error);
        }

        /// <summary>
        /// PingBack is called in response to a ping for a few reasons:
        /// 1. This registers the node we're pinging in the sender's list of peers
        /// 2. It minimally verifies that the sender is a peer.
        /// 3. We can't simply ping the sender of the ping we received, as this would create an infinite loop of ping - reping.
        /// NOTE: THIS IS NOT IN THE KADEMLIA SPEC EXCEPT FOR DISCUSSION OF "piggyback" PING RESPONSE.
        public RpcError PingBack(Contact sender)
        {
            ErrorResponse error;
            ID id = ID.RandomID;
            bool timeoutError;

            var ret = RestCall.Post<FindValueResponse, ErrorResponse>(url + ":" + port + "//PingBack",
                new PingSubnetRequest()
                {
                    Protocol = sender.Protocol,
                    ProtocolName = sender.Protocol.GetType().Name,
                    Sender = sender.ID.Value,
                    RandomID = id.Value
                },
                out error, out timeoutError);

            return GetRpcError(id, ret, timeoutError, error);
        }

        public RpcError Store(Contact sender, ID key, string val, bool isCached = false, int expirationTimeSec = 0)
        {
            ErrorResponse error;
            ID id = ID.RandomID;
            bool timeoutError;

            var ret = RestCall.Post<FindValueResponse, ErrorResponse>(url + ":" + port + "//Store",
                    new StoreSubnetRequest()
                    {
                        Protocol = sender.Protocol,
                        ProtocolName = sender.Protocol.GetType().Name,
                        Sender = sender.ID.Value,
                        Key = key.Value,
                        Value = val,
                        IsCached = isCached,
                        ExpirationTimeSec = expirationTimeSec,
                        RandomID = id.Value
                    }, 
                    out error, out timeoutError);

            return GetRpcError(id, ret, timeoutError, error);
        }

        protected RpcError GetRpcError(ID id, BaseResponse resp, bool timeoutError, ErrorResponse peerError)
        {
            return new RpcError() { IDMismatchError = id != resp.RandomID, TimeoutError = timeoutError, PeerError = peerError != null, PeerErrorMessage = peerError?.ErrorMessage };
        }

        protected List<Contact> EmptyContactList()
        {
            return new List<Contact>();
        }
    }
}
