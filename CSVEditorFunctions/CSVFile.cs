using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVEditorFunctions
{
    public class CSVFile
    {
        public CSVFile(string filePath)
        {
            FileContents = new List<string>();
            FileName = filePath;
            using (StreamReader reader = new StreamReader(FileName))
            {
                while (!reader.EndOfStream)
                {
                    FileContents.Add(reader.ReadLine());
                }
            }
        }
        public string FileName { get; set; }
        public List<string> FileContents { get; set; }




    }
}
