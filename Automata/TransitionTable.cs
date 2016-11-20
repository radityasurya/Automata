using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class TransitionTable
    {
        private Dictionary<KeyValuePair<State, char>, State> transitions;
        public bool Finished { get; set; }

        public TransitionTable()
        {
            this.transitions = new Dictionary<KeyValuePair<State, char>, State>();
            this.Finished = false;
        }

        public void AddTransition(State current, char token, State next)
        {
            if (Finished)
            {
                
            } else
            {
                State nextStates;

                var key = new KeyValuePair<State, char>(current, token);

                bool isTransitionExist = transitions.TryGetValue(key, out nextStates);

                if (!isTransitionExist)
                {
                    transitions.Add(key, next);
                }

            }
        }

        public State GetNextStates(State s, char c)
        {
            State nextState;

            KeyValuePair<State, char> key = new KeyValuePair<State, char>();

            foreach (var k in transitions.Keys)
            {
                if (k.Key.Name == s.Name && k.Key.isFinal == s.isFinal)
                {
                    key = k;
                }
            }

            bool transitionIsDefined = transitions.TryGetValue(key, out nextState);


            return nextState;

        }


    }
}
