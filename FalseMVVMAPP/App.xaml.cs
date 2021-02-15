using FalseMVVMAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FalseMVVMAPP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindowViewModel _vm;
        public App()
        {
            _vm = new MainWindowViewModel();
            MainVindowVM = _vm;
        }
        public MainWindowViewModel MainVindowVM { get; private set; }

        public EmployeeViewModel EmployeeDialogVM
        {
            get
            {
                return new EmployeeViewModel();
            }
        }
    }
}
