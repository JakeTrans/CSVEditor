using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVEditorFunctions
{
    /// <summary>
    /// Class Representing a single CSV file
    /// </summary>
    public class CSVFile
    {
        /// <summary>
        /// Open a CSV file into the class
        /// </summary>
        /// <param name="filePath">Path of the File do load</param>
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
        /// <summary>
        /// The File Path
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// CSV file Represented as a list List
        /// </summary>
        public List<string> FileContents { get; set; }




    }
}
