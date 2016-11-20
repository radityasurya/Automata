using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Automata
{
    public class FileHelper
    {
        public List<string> lines { get; set; } 
        public string filepath { get; set; }
        public FileHelper()
        {
        }

        public List<string> Load(string filePath)
        {
            this.filepath = filePath;
            List<string> result = new List<string>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        // ignore comment
                        if(!line.Contains('#'))
                        {
                            result.Add(line);

                        }
                    }
                }

                lines = result;
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            // Remove whitespaces
            result = result.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            return result;
        }

        public void buildGraph()
        {
            Process dot = new Process();

            dot.StartInfo.FileName = @"C:\Program Files (x86)\Graphviz2.38\bin\dot.exe";
            dot.StartInfo.Arguments = "-Tpng -oabc.png abc.dot";

            dot.Start();
            dot.WaitForExit();
        }

        public void UpdateFile(string type, bool isDFA)
        {
            if (type == "write")
            {
                using (TextWriter tw = new StreamWriter(filepath))
                {
                    foreach (String s in lines)
                    {
                        tw.WriteLine(s);
                    }

                    if (isDFA)
                    {
                        tw.WriteLine("dfa: y");
                    }
                    else
                    {
                        tw.WriteLine("dfa: n");
                    }
                }
            } else
            {
                using (TextWriter tw = new StreamWriter(filepath))
                {
                    foreach (string s in lines)
                    {
                        if (s.Contains("dfa"))
                        {
                            if (isDFA)
                            {
                                tw.WriteLine("dfa: y");
                            }
                            else
                            {
                                tw.WriteLine("dfa: n");
                            }
                        } else
                        {
                            tw.WriteLine(s);
                        }
                    }
                }
            }
            
                
        }
        
    }
}
