using CSVEditorForm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace CSVEditorForm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public DataTable CSVTable { get; }
        public ObservableCollection<dynamic> DynamicCSV { get; }

        public ObservableCollection<Person> People { get; }

        public MainWindowViewModel()
        {
            CSVTable = GetTable();

            DynamicCSV = new ObservableCollection<dynamic>(CSVTable.ToDynamic());
            People = new ObservableCollection<Person>(GenerateMockPeopleTable());
        }

        private static DataTable GetTable()
        {
            // Step 2: here we create a DataTable.
            // ... We add 4 columns, each with a Type.
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Step 3: here we add 5 rows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }

        private IEnumerable<Person> GenerateMockPeopleTable()
        {
            var defaultPeople = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Pat",
                    LastName = "Patter",
                    EmployeeNumber = 1010,
                    DepartmentNumber = 100,
                    DeskLocation = "B3F3R5T7"
                },
                new Person()
                {
                    FirstName = "Jean",
                    LastName = "Jones",
                    EmployeeNumber = 973,
                    DepartmentNumber = 200,
                    DeskLocation = "B1F1R2T3"
                },
                new Person()
                {
                    FirstName = "Terry",
                    LastName = "Tompson",
                    EmployeeNumber = 300,
                    DepartmentNumber = 100,
                    DeskLocation = "B3F2R10T1"
                }
            };

            return defaultPeople;
        }
    }
}