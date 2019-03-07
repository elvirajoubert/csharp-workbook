using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files

{
    class Program {
        static void Main (string[] args) {

            string filesPath = ".\\wordguess.txt";
            Files f = new Files ();
            string filePath = f.createFile ("example1");
            f.editFile (filesPath);
            string filesPath2 = f.createFile ("example2");
            f.removeFile (filesPath2);
            f.longestWord (filesPath);


        }
        class Files {
            private string spec1 = "This is a text file.";
            private string spec2 = "This is a text file and I can edit it.";
            public string createFile (string myFileName) {
                string txt = ".txt";
                string fullFileName = myFileName + txt;
                string myPath = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);

                string fullPath = $"{myPath}\\{fullFileName}";

                using (FileStream fs = File.Create (fullPath))
                using (StreamWriter sw = new StreamWriter (fs)) {
                    sw.WriteLine (spec1);
                }
                Console.WriteLine ("Completed");
                return fullPath;

            }

            public void removeFile (string fileName) {
                File.Delete (fileName);
                Console.WriteLine ("This file has been deleted");
            }

            public string editFile (string path) {
                using (FileStream fs1 = File.OpenWrite (path))
                using (StreamWriter sw1 = new StreamWriter (fs1)) {
                    sw1.WriteLine (spec2);
                }
                Console.WriteLine ("The file at {0} has been edited", path);
                return path;

            }

            public void numberOfWords (string filePath) {
                string[] wordsSentence;
                wordsSentence = File.ReadAllLines (filePath, Encoding.UTF8);
                int count = wordsSentence.Length;
                Console.WriteLine ("Total number of words in this file is.{0}", count);
            }

            public void longestWord (string filePath) {
                var file = File.ReadAllLines (filePath, Encoding.UTF8);
                var wordList = new List<string> (file);
                string longestWord = "";
                int longest = 0;

                foreach (string s in wordList) {
                    if (s.Length > longest) {
                        longestWord = s;
                        longest = s.Length;
                    }
                }
                Console.WriteLine ("The longest word is {0}", longestWord);

            }

        }
    }
}