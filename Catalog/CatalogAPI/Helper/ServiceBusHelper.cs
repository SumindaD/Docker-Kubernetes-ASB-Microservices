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
            queueClient = new QueueClient(Environment.GetEnvironmentVariable("SB_CONNECTION"), Environment.GetEnvironmentVariable("QUEUENAME"));

            var serviceBusMessage = new Message(Encoding.UTF8.GetBytes(message));

            await queueClient.SendAsync(serviceBusMessage);
            await queueClient.CloseAsync();
        }
    }
}
