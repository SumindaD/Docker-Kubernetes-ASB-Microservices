using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogAPI.Helper
{
    public static class ServiceBusHelper
    {
        static IQueueClient queueClient;

        public static async Task SendMessageAsync(string message)
        {
            queueClient = new QueueClient("Endpoint=sb://servicebusmsn1.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=H7P2PwC6xX9Q21c/p2A2hcTWg6F9apsGfhhfXIiBpCA=", Environment.GetEnvironmentVariable("QUEUENAME"));

            var serviceBusMessage = new Message(Encoding.UTF8.GetBytes(message));

            await queueClient.SendAsync(serviceBusMessage);
            await queueClient.CloseAsync();
        }
    }
}
