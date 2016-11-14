using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class State
    {
        public string Name { get; private set; }
        public bool isFinal { get; set; }

        public State(string name)
        {
            this.Name = name;
            this.isFinal = false;
        }
    }
}
