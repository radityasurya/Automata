using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Automata
{
    public class Automaton
    {
        public Alphabet Alphabets;
        public State[] states, finals;
        public State initial;
        public TransitionTable table;

        public Automaton(State[] state, char[] alphabet, Transition[] transitions, State[] finalStates)
        {
            validateAlphabet(alphabet);
            this.Alphabets = new Alphabet(alphabet);

            this.states = new State[state.Count()];
            for (int i = 0; i < state.Count(); i++)
            {
                this.states[i] = state[i];
            }

            this.finals = new State[finalStates.Count()];
            for (int i = 0; i < finalStates.Count(); i++)
            {
                this.finals[i] = finalStates[i];
            }

            this.initial = states[0];

            this.table = new TransitionTable();

            foreach (var info in transitions)
            {
                //AddTransition(info);
            }

        }

        public void AddTransition(Transition t)
        {
            char c = t.Token;

            State current = t.CurrentState;
            State next = t.NextState;

            table.AddTransition(current, c, next);
        }

        public bool validateAlphabet(char[] a)
        {
            bool isValid = true;

            return isValid;
        }

        public bool AcceptString(string input)
        {
            return true;
        }

        public bool hasAcceptingState(IEnumerable<State> currents)
        {
            foreach (var s in currents)
            {
                if (finals.Contains(s))
                {
                    return true;
                }
                
            }

            return false;
        }

    }
}