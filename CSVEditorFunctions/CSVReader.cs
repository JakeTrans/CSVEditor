using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CSVEditorFunctions
{
    public class CSVReader
    {

        public string CurrentFile { get; set; }

        DataTable CSVDT;

        public void ReadFile(string FilePath)
        {


        }

        public void WriteFile(string filepath)
        {

        }

        private void TranslateCSVtoTable()
        {
            CSVDT = new DataTable();
        }

    }
}
