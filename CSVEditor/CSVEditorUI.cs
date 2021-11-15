using System;
using System.Windows.Forms;

namespace CSVEditor
{
    public partial class CSVEditorUI : Form
    {
        private readonly CSVEditorFunctions.CSVEditor CSV = new CSVEditorFunctions.CSVEditor();

        public CSVEditorUI()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Select a CSV File",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            })
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TSSLFileStatus.Text = "Loading...";
                    CSV.ReadFile(openFileDialog1.FileName);
                    dgvCSVOutput.DataSource = CSV.CSVDT;
                    TSSLFileStatus.Text = "Current File - " + openFileDialog1.FileName;
                    btnSave.Enabled = true;
                    btnSaveAs.Enabled = true;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            CSV.WriteFile(chkAddQuotationMarks.Checked);
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Select a Save Location",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            })
            {
                if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TSSLFileStatus.Text = "Saving...";
                    CSV.WriteFile(saveFileDialog.FileName, chkAddQuotationMarks.Checked);
                    TSSLFileStatus.Text = "Current File - " + saveFileDialog.FileName;
                }
            }
        }
    }
}