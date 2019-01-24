using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace CSVEditorFunctions
{
    public class CSVEditor
    {

        public DataTable CSVDT;
        public CSVFile Currentfile;
        public void ReadFile(string FilePath)
        {
            Currentfile = new CSVFile(FilePath);
            TranslateCSVtoTable();
        }

        public void WriteFile()
        {
            StringBuilder csvfileOutput = new StringBuilder();
            int ColumnCount = CSVDT.Columns.Count;
            //headers
            foreach (DataColumn column in CSVDT.Columns)
            {
                csvfileOutput.Append(column.Caption + ",");
            }
            //remove last character
            csvfileOutput.Remove(csvfileOutput.Length - 1, 1);
            csvfileOutput.Append(Environment.NewLine);

            //foreach (DataRow Row in CSVDT.Rows)
            for (int Row = 0; Row < CSVDT.Rows.Count - 1; Row++)
            {
                for (int i = 0; i < ColumnCount; i++)
                {
                    csvfileOutput.Append(CSVDT.Rows[Row][i].ToString() + ",");
                }
                csvfileOutput.Remove(csvfileOutput.Length - 1, 1);
                csvfileOutput.Append("\r");
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter(Currentfile.FileName);
            file.WriteLine(csvfileOutput.ToString()); // "sb" is the StringBuilder
            file.Dispose();
        }


        public void WriteFile(string NewFilePath)
        {
            Currentfile.FileName = NewFilePath;
            WriteFile();
        }


        private void TranslateCSVtoTable()
        {
            CSVDT = new DataTable();

            int ColumnCount = 0;


            //work out max columns

            foreach (string CurrentLine in Currentfile.FileContents)
            {
                int Linecolumncount = CurrentLine.Count(x => x == ',');

                if (Linecolumncount > ColumnCount)
                {
                    ColumnCount = Linecolumncount;
                }
            }


            //header
            string[] Headers = Currentfile.FileContents[0].Split(',');


            foreach (string Header in Headers)
            {
                CSVDT.Columns.Add(Header);
            }

            if (Headers.Count() < ColumnCount)
            {
                //add extra columns
                CSVDT.Columns.Add();
            }

            //text
            for (int i = 1; i < Currentfile.FileContents.Count ; i++)
            {
                string[] CurrentRow = Currentfile.FileContents[i].Split(',');
                DataRow dr = CSVDT.NewRow();
                dr.ItemArray = CurrentRow;
                CSVDT.Rows.Add(dr);
            }
        }

        


    }
}
