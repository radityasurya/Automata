using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata
{
    public class AutomataManager
    {
        private FileHelper fh;

        // Variables
        private List<string> loadedFileList = new List<string>();
        private List<char> alphabets = new List<char>();
        private List<char> states = new List<char>();
        private List<char> finalStates = new List<char>();

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
        }

        public void getAlphabets()
        {
            string result = loadedFileList.Find(item => item.Contains("alphabet"));
        }

        public void getStates()
        {
            string result = loadedFileList.Find(item => item.Contains("states"));

        }

        public void getFinalState()
        {
            string result = loadedFileList.Find(item => item.Contains("final"));
        }

    }
}
