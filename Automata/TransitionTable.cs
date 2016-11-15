using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class TransitionTable
    {
        private Dictionary<Tuple<State, char>, List<State>> transitions;
        public bool Finished { get; set; }

        public TransitionTable()
        {
            this.transitions = new Dictionary<Tuple<State, char>, List<State>>();
            this.Finished = false;
        }

        public void AddTransition(State current, char token, State next)
        {
            if (Finished)
            {
                
            } else
            {
                List<State> nextStates;

                var key = new Tuple<State, char>(current, token);

                bool isTransitionExist = transitions.TryGetValue(key, out nextStates);

                if (!isTransitionExist)
                {
                    nextStates = new List<State>();
                    transitions.Add(key, nextStates);
                }

                bool isDuplicated = nextStates.Contains(next);
                if (isDuplicated)
                {

                } else
                {
                    nextStates.Add(next);
                }
            }
        }
    }
}
