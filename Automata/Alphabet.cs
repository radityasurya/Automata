using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class Alphabet
    {
        public char[] Characters { get; set; }

        public Alphabet(char[] chars)
        {
            this.Characters = chars;
        }

        public bool Contains(char c)
        {
            return Characters.Contains(c);
        }
    }
}
