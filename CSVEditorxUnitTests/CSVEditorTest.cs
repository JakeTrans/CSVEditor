using CSVEditorFunctions;
using System;
using System.Data;
using System.IO;
using Xunit;

namespace CSVEditorxUnitTests
{
    public class CSVEditorTest
    {
        [Fact]
        public void BaseCSVReadTest()
        {
            string filename = "./Resources/FL_insurance_sample.csv";

            CSVEditor CSVEdit = new CSVEditor();

            CSVEdit.ReadFile(filename);

            Assert.Equal(18, CSVEdit.CSVDT.Columns.Count);
            Assert.Equal(36635, CSVEdit.CSVDT.Rows.Count);
        }

        [Fact]
        public void BaseCSVWriteTest()
        {
            string filename = "./Resources/FL_insurance_sample.csv";
            string destfilename = "./Resources/FL_insurance_sample2.csv";
            CSVEditor CSVEdit = new CSVEditor();

            CSVEdit.ReadFile(filename);

            CSVEdit.WriteFile(destfilename,false);

            CSVEdit.ReadFile(destfilename);

            File.Delete(destfilename);

            Assert.Equal(18, CSVEdit.CSVDT.Columns.Count);
            Assert.Equal(36635, CSVEdit.CSVDT.Rows.Count);


        }

        [Fact]
        public void JaggedCSVWriteTest()
        {

            string filename = "./Resources/JaggedCSV.csv";

            CSVEditor CSVEdit = new CSVEditor();

            CSVEdit.ReadFile(filename);

            Assert.Equal(4, CSVEdit.CSVDT.Columns.Count);
            Assert.Equal(3, CSVEdit.CSVDT.Rows.Count);
        }

        [Fact]
        public void BaseCSVWriteTestWithQuotationMarks()
        {
            string filename = "./Resources/FL_insurance_sample.csv";
            string destfilename = "./Resources/FL_insurance_sample3.csv";
            CSVEditor CSVEdit = new CSVEditor();

            CSVEdit.ReadFile(filename);

            CSVEdit.WriteFile(destfilename, true);

            CSVEdit.ReadFile(destfilename);

            File.Delete(destfilename);

            Assert.Equal(18, CSVEdit.CSVDT.Columns.Count);
            Assert.Equal(36635, CSVEdit.CSVDT.Rows.Count);


        }
    }
}
