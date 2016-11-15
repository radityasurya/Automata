using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class DFA
    {

        public char[] Alphabets { get; set; }
        public List<State> States { get; set; }
        public List<Transition> Transitions { get; set; }

        public State CurrentState { get; set; }

        public DFA(char[] alphabets, List<Transition> transition, List<State> states)
        {
            this.Alphabets = alphabets;
            this.States = states;
            this.Transitions = transition;
        }

        public bool isDFA()
        {
            if (!isEpsilonExist())
            {
                if (isHavingCorrectTransitions())
                {
                    return true;
                } else
                {
                    return false;
                }

            } else
            {
                return false;
            }

        }

        public bool isEpsilonExist()
        {
            if (Transitions.Exists(x => x.Token == 'ε'))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool isHavingCorrectTransitions()
        {
            int counter = 0;
            int expectedResult = Alphabets.Count() * States.Count();
            // check if all the states has all the alphabets with the correct transitions
            foreach (var t in Transitions)
            {
                foreach (var s in States)
                {
                    if (t.CurrentState == s.Name)
                    {
                        foreach (var a in Alphabets)
                        {
                            if (t.Token == a)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }

            if (counter != expectedResult)
            {
                return false;
            }
            return true;
        }

    }
}
