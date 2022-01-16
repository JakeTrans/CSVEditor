using CSVEditorForm.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CSVEditorForm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Person> People { get; }

        public MainWindowViewModel()
        {
            People = new ObservableCollection<Person>(GenerateMockPeopleTable());
        }

        private IEnumerable<Person> GenerateMockPeopleTable()
        {
            var defaultPeople = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Pat",
                    LastName = "Patterson",
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