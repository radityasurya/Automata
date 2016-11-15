using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class Transition
    {
        public char CurrentState { get; set; }
        public char Token { get; set; }
        public char NextState { get; set; }

        public Transition(char currentState, char token, char nextState)
        {
            this.CurrentState = currentState;

            if(token == '_')
            {
                this.Token = 'ε';
            } else
            {
                this.Token = token;
            }
            this.NextState = nextState;    
        }

        public override string ToString()
        {
            return string.Format("\"{0}\" -> " + "\"{1}\" [label=" + "\"{2}\"]", CurrentState, NextState, Token);
        }
    }
}
