﻿using System;
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

        // Variables
        private List<string> loadedFileList = new List<string>();
        private List<char> alphabets = new List<char>();
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
        }

        public void getStates()
        {
            string result = loadedFileList.Find(item => item.Contains("states"));
            result = result.Split(':').Last();
            result = result.Trim();

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

        public void getTransition()
        {
            var startIndex = loadedFileList.FindIndex(item => item.Contains("transitions"));
            var endIndex = loadedFileList.FindIndex(item => item.Contains("end"));

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

                var startState = result[0];
                var token = Convert.ToChar(result[1].Trim());
                var endState = result[2].Trim();

                transitions.Add(new Transition(startState, token, endState));
            }
            

        }

        public void GenerateDot()
        {
            List<string> lines = new List<string>();

            lines.Add("digraph myAutomaton {");
            lines.Add("   rankdir=LR;");

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
