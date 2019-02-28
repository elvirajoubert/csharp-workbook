using System;
using System.IO;

namespace Files
{
    class Program
    {
        public static void SimpleWay(string[] args)
        {
            string textToWrite = string.Join(" ", args);

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string documentName = "Simple Way";
            string documentExtention = "txt";
            string fullPathToFile = $"{documentsPath}/{documentName}.{documentExtension}";
        }

        // {
        //     Output();
        //     public static void  IEnumerable<string> Input; 

        //     List <String> output;

        //     foreach (string item in input)
        //     {
        //         if (item.Length > 3)
        //         {
        //         return output.Add(item);
        //         }
        //     }
        //     return output;

        // }
    }
}
