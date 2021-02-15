using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalseMVVMAPP.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ICollection<EmployeeViewModel> _employees;

        public ICollection<EmployeeViewModel> Employees
        {
            get { return _employees; }
            set 
            { 
                _employees = value;
                NotifyPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            _employees = new List<EmployeeViewModel>()
            {
                new EmployeeViewModel()
                {
                    Name = "sdadas",
                    Taj = "asdasdsadsadas",
                    Salary = 200000
                }
            };
        }
    }
}
