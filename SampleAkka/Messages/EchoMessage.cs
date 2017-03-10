using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAkka.Messages
{
    public class EchoMessage
    {
        public string Name { get; }

        public EchoMessage(string name)
        {
            Name = name;
        }
    }
}
