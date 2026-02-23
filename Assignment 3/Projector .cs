using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Projector
    {
        public void Start() => Console.WriteLine("Projector started.");
        public void close() => Console.WriteLine("Projector stopped.");
    }
}
