using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FalseMVVMAPP.ViewModels
{
    public class EmployeeViewModel : BaseViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set 
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        private string _taj;

        public string Taj
        {
            get { return _taj; }
            set { 
                _taj = value;
                NotifyPropertyChanged();
            }
        }

        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set 
            { 
                _salary = value;
                NotifyPropertyChanged();
            }
        }

    }
}
