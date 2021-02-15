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
        }

        public void DeleteSelectedItem()
        {
            Employees.Remove(SelectedEmployee);
            SelectedEmployee = null;
        }
    }
}
