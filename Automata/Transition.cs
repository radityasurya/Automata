using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class Transition
    {
        public string StartState { get; set; }
        public char Token { get; set; }
        public string EndState { get; set; }

        public Transition(string startState, char token, string endState)
        {
            this.StartState = startState;

            if(token == '_')
            {
                this.Token = 'ε';
            } else
            {
                this.Token = token;
            }
            this.EndState = endState;    
        }

        public override string ToString()
        {
            return string.Format("\"{0}\" -> " + "\"{1}\" [label=" + "\"{2}\"]", StartState, EndState, Token);
        }
    }
}
