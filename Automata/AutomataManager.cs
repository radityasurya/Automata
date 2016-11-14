using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Automata
{
    public class AutomataManager
    {
        private FileHelper fh;

        // Variables
        private List<string> loadedFileList = new List<string>();
        private List<char> alphabets = new List<char>();
        private List<State> states = new List<State>();

        public AutomataManager()
        {
            fh = new FileHelper();
        }

        public void readNDFA(string filePath)
        {
            loadedFileList = fh.Load(filePath);

            fh.buildGraph();

            getAlphabets();
            getStates();
            getFinalState();

            states.Count();
        }

        public void getAlphabets()
        {
            string result = loadedFileList.Find(item => item.Contains("alphabet"));
        }

        public void getStates()
        {
            string result = loadedFileList.Find(item => item.Contains("states"));
            result = result.Split(':').Last();

            string[] _state = result.Split(',');

            foreach (var s in _state)
            {
                states.Add(new State(s));
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
                    if (s.Name.Equals(_s))
                    {
                        s.isFinal = true;
                    }
                }
            }
        }

    }
}
