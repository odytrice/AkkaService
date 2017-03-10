using Akka.Actor;
using SampleAkka.Actors;
using SampleAkka.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAkka
{
    public class SampleAkkaService
    {
        ActorSystem _system;
        public void Start()
        {
            _system = ActorSystem.Create("SampleAkkSystem");


            var echoActor = _system.ActorOf<EchoActor>();

            _system.Scheduler.ScheduleTellRepeatedly(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(5), echoActor, new EchoMessage("Dare"), echoActor);
        }

        public void Stop()
        {
            _system.Terminate();
        }
    }
}
