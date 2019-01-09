﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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

        public void WriteFile(string filepath)
        {

        }

        private void TranslateCSVtoTable()
        {
            CSVDT = new DataTable();

            //header
            string[] Headers = Currentfile.FileContents[0].Split(',');

            foreach (string Header in Headers)
            {
                CSVDT.Columns.Add(Header);
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