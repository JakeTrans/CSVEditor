﻿using CSVEditorFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVEditor
{
    public partial class CSVReaderUI : Form
    {
        CSVReader CSV = new CSVReader();


        public CSVReaderUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select a CSV File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                CSV.ReadFile(openFileDialog1.FileName);
                dgvCSVOutput.DataSource = CSV.CSVDT;
            }
        }
    }
}
