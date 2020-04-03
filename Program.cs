using System;
using Microsoft.Azure.ServiceBus;

namespace publisher
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Microsoft.Azure.ServiceBus.QueueClient queueClient = new QueueClient("Endpoint=sb://singheveloper-azure.servicebus.windows.net/;SharedAccessKeyName=testQueueMng;SharedAccessKey=ASUse6UlF71pw9LZCOfAcuexfq+pwfiVpvfQPcxzNvk=;","testqueue");
            do 
            {
                Console.WriteLine("Enter Value ");
                var s = Console.ReadLine();
                if(s.StartsWith("end"))
                    break;  
                var bd =  new Message(System.Text.Encoding.UTF8.GetBytes(s));
                queueClient.SendAsync(bd).GetAwaiter().GetResult(); 
            } 
            while(true);

        }
    }
}
