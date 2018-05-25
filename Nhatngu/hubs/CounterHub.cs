using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
namespace Nhatngu.hubs
{
    public class CounterHub: Hub
    {
        static long counter = 5;
        public override System.Threading.Tasks.Task OnConnected()
        {
            counter ++;
            Clients.All.UpdateCount(counter);
            return base.OnConnected();
        }
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            counter--;
            Clients.All.UpdateCount(counter);
            return base.OnDisconnected(stopCalled);
        }
    }
}