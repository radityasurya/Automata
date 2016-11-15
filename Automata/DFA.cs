using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class DFA
    {
        public List<State> States { get; set; }
        public List<Transition> Alphabet { get; set; }

        public State CurrentState { get; set; }

        public DFA(List<Transition> alphabet, List<State> states)
        {
            this.States = states;
            this.Alphabet = alphabet;
        }

        public static bool CheckForDuplicates(string[] set)
        {
            return true;
        }
    }
}
