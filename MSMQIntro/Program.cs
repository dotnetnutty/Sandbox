using System;
using System.Messaging;

namespace MSMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //var msgQue = MessageQueue.Create(@".\private$\aq");

            string myString = "Somethingtoqueue";

            var mq = new MessageQueue(@".\private$\aq", QueueAccessMode.Send);
            mq.Send(myString, MessageQueueTransactionType.None);


            var retrievedMessage = mq.Receive(new TimeSpan(1000));
            string body = (string)retrievedMessage.Body;

            Console.WriteLine("Retrieved body = " + body);
        }
    }
}
