using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace CSVEditorFunctions
{
    /// <summary>
    /// Main Class Of the CSV Editor
    /// </summary>
    public class CSVEditor
    {
        /// <summary>
        /// DataTable Representing the CSV file
        /// </summary>
        public DataTable CSVDT;

        /// <summary>
        /// Base CSV file
        /// </summary>
        public CSVFile Currentfile;

        /// <summary>
        /// Read a CSV file in to the Class
        /// </summary>
        /// <param name="FilePath">Path of file to load</param>
        public void ReadFile(string FilePath)
        {
            Currentfile = new CSVFile(FilePath);
            TranslateCSVtoTable();
        }

        /// <summary>
        /// Convert the CSV file into a Datatable within the class
        /// </summary>
        /// <param name="FilePath">Path of file to load</param>
        /// <param name="RemoveApostrophes">inculde a " at the front and end of each field</param>
        public void ReadFile(string FilePath, bool RemoveApostrophes = false)
        {
            Currentfile = new CSVFile(FilePath);

            TranslateCSVtoTable(RemoveApostrophes); // pass in boolean
        }

        /// <summary>
        /// Write the file to the current Filepath
        /// </summary>
        /// <param name="IncludeQuotationMarks">Should " be added to the file</param>
        public void WriteFile(bool IncludeQuotationMarks)
        {
            StringBuilder csvfileOutput = new StringBuilder();
            int ColumnCount = CSVDT.Columns.Count;
            //headers
            foreach (DataColumn column in CSVDT.Columns)
            {
                if (IncludeQuotationMarks == true)
                {
                    csvfileOutput.Append("\"" + column.Caption + "\"" + ",");
                }
                else
                {
                    csvfileOutput.Append(column.Caption + ",");
                }
            }
            //remove last character
            csvfileOutput.Remove(csvfileOutput.Length - 1, 1);
            csvfileOutput.Append(Environment.NewLine);

            foreach (DataRow Row in CSVDT.Rows)
            {
                for (int i = 0; i < ColumnCount; i++)
                {
                    if (IncludeQuotationMarks == true)
                    {
                        csvfileOutput.Append("\"" + Row[i].ToString() + "\"" + ",");
                    }
                    else
                    {
                        csvfileOutput.Append(Row[i].ToString() + ",");
                    }
                }
                csvfileOutput.Remove(csvfileOutput.Length - 1, 1);
                csvfileOutput.Append("\r");
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(Currentfile.FileName);
            file.WriteLine(csvfileOutput.ToString()); // "sb" is the StringBuilder
            file.Dispose();
        }

        /// <summary>
        /// Write the file to a new Filepath
        /// </summary>
        /// <param name="NewFilePath">PAth to save the file too</param>
        /// <param name="IncludeQuotationMarks">inculde a " at the front and end of each field</param>
        public void WriteFile(string NewFilePath, bool IncludeQuotationMarks)
        {
            Currentfile.FileName = NewFilePath;
            WriteFile(IncludeQuotationMarks);
        }

        /// <summary>
        /// Convert the CSV file into a Datatable within the class
        /// </summary>
        private void TranslateCSVtoTable()
        {
            CSVDT = new DataTable();

            //header

            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            string[] Headers = CSVParser.Split(Currentfile.FileContents[0]);

            foreach (string Header in Headers)
            {
                CSVDT.Columns.Add(Header);
            }

            //text
            for (int i = 1; i < Currentfile.FileContents.Count; i++)
            {
                string[] CurrentRow = CSVParser.Split(Currentfile.FileContents[i]);

                if (CurrentRow.Length > CSVDT.Columns.Count)
                {
                    CSVDT.Columns.Add("");
                }
                DataRow dr = CSVDT.NewRow();
                dr.ItemArray = CurrentRow;
                CSVDT.Rows.Add(dr);
            }
        }

        /// <summary>
        /// Convert the CSV file into a Datatable within the class
        /// </summary>
        /// <param name="RemoveApostrophes">Removes all Apostrophes</param>
        private void TranslateCSVtoTable(bool RemoveApostrophes)
        {
            CSVDT = new DataTable();

            //header

            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            string[] Headers = CSVParser.Split(Currentfile.FileContents[0]);

            foreach (string Header in Headers)
            {
                if (RemoveApostrophes == true)
                    CSVDT.Columns.Add(Header.Replace("'", ""));
                else
                    CSVDT.Columns.Add(Header);
            }

            //text
            for (int i = 1; i < Currentfile.FileContents.Count; i++)
            {
                string[] CurrentRow;
                if (RemoveApostrophes == true)
                    CurrentRow = CSVParser.Split(Currentfile.FileContents[i].Replace("'", ""));
                else
                    CurrentRow = CSVParser.Split(Currentfile.FileContents[i]);

                DataRow dr = CSVDT.NewRow();

                dr.ItemArray = CurrentRow;

                CSVDT.Rows.Add(dr);
            }
        }
    }
}