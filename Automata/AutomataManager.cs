using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;


namespace Automata
{
    public class AutomataManager
    {
        private FileHelper fh;
        private DFA dfa;

        // Variables
        private List<string> loadedFileList = new List<string>();
        private Alphabet alphabet;
        private List<State> states = new List<State>();
        private List<Transition> transitions = new List<Transition>();

        public AutomataManager()
        {
            fh = new FileHelper();
        }

        public void readNDFA(string filePath)
        {
            loadedFileList = fh.Load(filePath);

            getAlphabets();
            getStates();
            getFinalState();
            getTransition();

            GenerateDot();
            fh.buildGraph();

            states.Count();
        }

        public void getAlphabets()
        {
            string result = loadedFileList.Find(item => item.Contains("alphabet"));
            result = result.Split(':').Last();
            result = result.Trim();
            
            List<char> alphabets = new List<char>();

            foreach (var c in result)
            {
                alphabets.Add(Convert.ToChar(c));
            }

            alphabet = new Alphabet(alphabets.ToArray());

        }

        public void getStates()
        {
            string result = loadedFileList.Find(item => item.Contains("states"));
            result = result.Split(':').Last();
            result = result.Trim();

            string[] _state = result.Split(',');

            foreach (var s in _state)
            {
                states.Add(new State(Convert.ToChar(s)));
            }
        }

        public void getFinalState()
        {
            string result = loadedFileList.Find(item => item.Contains("final"));
            result = result.Split(':').Last();
            result = result.Trim();

            List<string> _state = new List<string>();

            if (result.Contains(','))
            {
                _state = result.Split(',').ToList();
            } else
            {
                _state.Add(result);
            }

            foreach (var _s in _state)
            {

                foreach (var s in states)
                {
                    if (s.Name.Equals(Convert.ToChar(_s)))
                    {
                        s.isFinal = true;
                    }
                }
            }
        }

        public void getTransition()
        {
            var startIndex = loadedFileList.FindIndex(item => item.Contains("transitions"));
            var endIndex = loadedFileList.FindIndex(item => item.Contains("end"));

            transitions.Clear();

            var _transitions = new List<string>();

            for (int i = startIndex + 1; i < loadedFileList.Count; i++)
            {
                if (loadedFileList[i] == "end.")
                {
                    break;
                }

                _transitions.Add(loadedFileList[i].Trim());
            }

            foreach (var s in _transitions)
            {

                string[] separators = { ",", "-->" };
                string[] result = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                var startState = Convert.ToChar(result[0]);
                var token = Convert.ToChar(result[1].Trim());
                var endState = Convert.ToChar(result[2].Trim());

                transitions.Add(new Transition(startState, token, endState));
            }
            

        }

        public bool isDFA()
        {
            string result = loadedFileList.Find(item => item.Contains("dfa"));

            // check if dfa is set or not
            if (result == null)
            {
                return false;
            }
            else
            {
                result = result.Split(':').Last();
                result = result.Trim();

                //if (result != "y")
                //{
                //    return false;
                //}
                //return true;
                dfa = new DFA(alphabet.Characters, transitions, states);

                return dfa.isDFA();
                
            }

        }

        public bool isFinite()
        {
            string result = loadedFileList.Find(item => item.Contains("finite"));
            
            // check if dfa is set or not
            if (result == null)
            {
                return false;
            }
            else
            {
                result = result.Split(':').Last();
                result = result.Trim();

                if (result != "y")
                {
                    return false;
                }
                return true;
            }
        }

        public bool isWords()
        {
            string result = loadedFileList.Find(item => item.Contains("words"));
            // check if dfa is set or not
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void GenerateDot()
        {
            List<string> lines = new List<string>();

            lines.Add("digraph myAutomaton {");
            lines.Add("   rankdir=LR;");

            lines.Add(string.Format("\"\" [shape=none]"));

            // draw states
            foreach (var s in states)
            {
                string circle = "circle";
                if(s.isFinal)
                {
                    circle = "doublecircle";
                }

                lines.Add(string.Format("\"{0}\" [shape={1}]", s.Name, circle));
            }

            lines.Add(string.Format("\"\" -> " + "\"{0}\"", transitions[0].CurrentState));

            // draw transitions
            foreach (var t in transitions)
            {
                lines.Add(t.ToString());
            }

            lines.Add("}");

            using (StreamWriter sw = new StreamWriter("abc.dot", false))
            {
                foreach (var l in lines)
                {
                    sw.WriteLine(l);
                }
            }
        }

    }
}
