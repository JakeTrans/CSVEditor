using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVEditorForm
{
    //Using the following answer
    //https://stackoverflow.com/a/7794962
    public static class DataTableExtensions
    {
        public static IEnumerable<dynamic> ToDynamic(this DataTable dt)
        {
            ObservableCollection<dynamic>? dynamicDt = new ObservableCollection<dynamic>();
            foreach (DataRow row in dt.Rows)
            {
                dynamic dyn = new ExpandoObject();
                dynamicDt.Add(dyn);
                foreach (DataColumn column in dt.Columns)
                {
                    var dic = (IDictionary<string, object>)dyn;
                    dic[column.ColumnName] = row[column];
                }
            }
            return dynamicDt;
        }
    }
}