using Akka.Actor;
using SampleAkka.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAkka.Actors
{
    public class EchoActor : ReceiveActor
    {
        public EchoActor()
        {
            Receive<EchoMessage>(m => Echo(m));
        }

        private void Echo(EchoMessage message)
        {
            //Do Whatever you like Here
            Console.WriteLine($"Hello {message.Name}");
        }
    }
}
