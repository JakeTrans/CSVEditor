using CSVEditorFunctions;
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
            CSV.ReadFile(@"C:\csvreadertest\FL_insurance_sample.csv");
            dgvCSVOutput.DataSource = CSV.CSVDT;
        }
    }
}
