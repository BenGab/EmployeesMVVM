using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalseMVVMAPP.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<EmployeeViewModel> _employees;

        public ObservableCollection<EmployeeViewModel> Employees
        {
            get { return _employees; }
            set 
            { 
                _employees = value;
                NotifyPropertyChanged();
            }
        }

        private EmployeeViewModel _selectEmploye;

        public EmployeeViewModel SelectedEmployee
        {
            get { return _selectEmploye; }
            set 
            { 
                _selectEmploye = value;
                NotifyPropertyChanged();
            }
        }

        private decimal Avg = 0;


        public MainWindowViewModel()
        {
            _employees = new ObservableCollection<EmployeeViewModel>()
            {
                new EmployeeViewModel()
                {
                    Name = "sdadas",
                    Taj = "asdasdsadsadas",
                    Salary = 200000
                }
            };

            _employees.CollectionChanged += (s, e) => SetAvg();
        }

        public void DeleteSelectedItem()
        {
            Employees.Remove(SelectedEmployee);
            SelectedEmployee = null;
        }

        public void SetAvg()
        {
            if (Employees.Count > 0)
            {
                Avg = Employees.Average(x => x.Salary);
            }
        }
    }
}
