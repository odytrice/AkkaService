using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace SampleAkka
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(host =>
            {
                host.Service<SampleAkkaService>(config =>
                {
                    config.ConstructUsing(s => new SampleAkkaService());
                    config.WhenStarted(s => s.Start());
                    config.WhenStopped(s => s.Stop());
                });

                host.RunAsLocalSystem();
                host.SetDescription("Sample Akka Echo Service");
                host.SetDisplayName("Sample Akka");
                host.SetServiceName("Sample.Akka");
            });
        }
    }
}
