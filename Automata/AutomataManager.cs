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
        private Alphabet Alphabets;
        private List<State> States = new List<State>();
        private List<Transition> Transitions = new List<Transition>();

        public AutomataManager()
        {
            fh = new FileHelper();
        }

        public void readNDFA(string filePath)
        {
            loadedFileList = fh.Load(filePath);

            getAlphabets();
            getStates();
            getTransition();

            GenerateDot();
            fh.buildGraph();

            States.Count();
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

            Alphabets = new Alphabet(alphabets.ToArray());

        }

        public void getStates()
        {
            string result = loadedFileList.Find(item => item.Contains("states"));
            result = result.Split(':').Last();
            result = result.Trim();

            string[] _state = result.Split(',');

            foreach (var s in _state)
            {
                States.Add(new State(Convert.ToChar(s)));
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

                foreach (var s in States)
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
            getFinalState();

            var startIndex = loadedFileList.FindIndex(item => item.Contains("transitions"));
            var endIndex = loadedFileList.FindIndex(item => item.Contains("end"));

            Transitions.Clear();

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

                var startState = getState(Convert.ToChar(result[0]));
                var token = Convert.ToChar(result[1].Trim());
                var endState = getState(Convert.ToChar(result[2].Trim()));

                Transitions.Add(new Transition(startState, token, endState));
            }

        }

        public State getState(char c)
        {
            State result = null;

            foreach (var s in States)
            {
                if (s.Name == c)
                {
                    result = s;
                }
            }

            return result;
        }

        public bool isDFA()
        {
            string result = loadedFileList.Find(item => item.Contains("dfa"));
            dfa = new DFA(Alphabets.Characters, Transitions, States);
            // check if dfa is set or not
            if (result == null)
            {
                fh.UpdateFile("write", dfa.isDFA());
            }
            else
            {
                result = result.Split(':').Last();
                result = result.Trim();

                

                fh.UpdateFile("update", dfa.isDFA());               
            }

            return dfa.isDFA();


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

        public bool isInAlphabets(char c)
        {
            foreach (var _c in Alphabets.Characters)
            {
                if (_c == c)
                {
                    return true;
                }
            }

            return false;
        }


        public bool checkString(string input)
        {
            if (input == " ") {
                return false;
            } else {
                return dfa.hasCorrectInput(input);
            }
        }

        public void GenerateAutomaton(Alphabet a)
        {
            var characters = new List<char>(a.Characters);
            foreach (Char c in a.Characters)
            {
                if (c != 'ε')
                {
                    characters.Add(c);
                }
            }

            var alphabet = characters.ToArray();

            var transitions = new List<Transition>(Transitions.Count);
            foreach (var transition in Transitions)
            {
                transitions.Add(new Transition(transition.CurrentState, transition.Token, transition.NextState));
            }

            List<State> finalStates = new List<State>();

            foreach (var state in States)
            {
                if(state.isFinal)
                {
                    finalStates.Add(state);
                }
            }

            dfa = new DFA(Alphabets.Characters, Transitions, States);
        }

        public void GenerateDot()
        {
            List<string> lines = new List<string>();

            lines.Add("digraph myAutomaton {");
            lines.Add("   rankdir=LR;");

            lines.Add(string.Format("\"\" [shape=none]"));

            // draw states
            foreach (var s in States)
            {
                string circle = "circle";
                if(s.isFinal)
                {
                    circle = "doublecircle";
                }

                lines.Add(string.Format("\"{0}\" [shape={1}]", s.Name, circle));
            }

            lines.Add(string.Format("\"\" -> " + "\"{0}\"", Transitions[0].CurrentState.Name));

            // draw transitions
            foreach (var t in Transitions)
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
