using Microsoft.AspNet.SignalR;
using Nhatngu.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nhatngu.hubs
{
    public class ChatHub: Hub
    {
        #region dataMember
        static List<UserDetail> ConnectedUsers = new List<UserDetail>();
        static List<MessengerDetail> CurrentMessage = new List<MessengerDetail>();
        #endregion

        #region Methods

        public void Connect(string userName)
        {
            var id = Context.ConnectionId;
            if (ConnectedUsers.Count(x => x.ConnectedId == id) == 0)
            {
                ConnectedUsers.Add(new UserDetail { ConnectedId = id, UserName = userName });
                //send to caller
                Clients.Caller.onConnected(id, userName, ConnectedUsers, CurrentMessage);

                //send to all except caller client
                Clients.AllExcept(id).onNewUserConnected(id, userName);
            }
        }
        public void SendMessageToAll(string userName, string message, TimeSpan timesend)
        {
            var id = Context.ConnectionId;
            // store last 100 messages in cache
            AddMessageinCache(id,userName, message, timesend);

            // Broad cast message
            Clients.All.messageReceived(id,userName, message, timesend);
        }

        public void SendPrivateMessage(string toUserId, string message)
        {

            string fromUserId = Context.ConnectionId;

            var toUser = ConnectedUsers.FirstOrDefault(x => x.ConnectedId == toUserId);
            var fromUser = ConnectedUsers.FirstOrDefault(x => x.ConnectedId == fromUserId);

            if (toUser != null && fromUser != null)
            {
                // send to 
                Clients.Client(toUserId).sendPrivateMessage(fromUserId, fromUser.UserName, message);

                // send to caller user
                Clients.Caller.sendPrivateMessage(toUserId, fromUser.UserName, message);
            }

        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            var item = ConnectedUsers.FirstOrDefault(x => x.ConnectedId == Context.ConnectionId);
            var item2 = CurrentMessage.SingleOrDefault(); 
            if (item != null)
            {
                ConnectedUsers.Remove(item);
                CurrentMessage.Remove(item2);
                var id = Context.ConnectionId;
                Clients.All.onUserDisconnected(id, item.UserName);
            }
            return base.OnDisconnected(stopCalled);
        }
        #endregion
        #region private Messages

        private void AddMessageinCache(string id, string userName, string message, TimeSpan sendtime)
        {

            CurrentMessage.Add(new MessengerDetail { Id=id, UserName = userName, Messenger = message, TimeSend = sendtime });

            if (CurrentMessage.Count > 100)
                CurrentMessage.RemoveAt(0);
        }

        #endregion
    }
}