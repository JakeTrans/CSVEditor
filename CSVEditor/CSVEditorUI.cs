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
    public partial class CSVEditorUI : Form
    {
        CSVEditorFunctions.CSVEditor CSV = new CSVEditorFunctions.CSVEditor();


        public CSVEditorUI()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Select a CSV File"
            };

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TSSLFileStatus.Text = "Loading...";
                CSV.ReadFile(openFileDialog1.FileName);
                dgvCSVOutput.DataSource = CSV.CSVDT;
                TSSLFileStatus.Text = "Current File - " + openFileDialog1.FileName;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CSV.WriteFile();
        }
    }
}
