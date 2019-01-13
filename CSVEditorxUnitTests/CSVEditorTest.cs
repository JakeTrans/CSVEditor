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
        public void BaseCsVReadTest()
        {
            var filename = "./Resources/FL_insurance_sample.csv";

            CSVEditor CSVEdit = new CSVEditor();

            CSVEdit.ReadFile(filename);


            Assert.Equal(18, CSVEdit.CSVDT.Columns.Count);
            Assert.Equal(36635, CSVEdit.CSVDT.Rows.Count);
        }


    }
}
