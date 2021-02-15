using FalseMVVMAPP.View;
using FalseMVVMAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FalseMVVMAPP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            EmpolyeeDialog dlg = new EmpolyeeDialog();
            if(dlg.ShowDialog() == true)
            {
                MainWindowViewModel vm = (MainWindowViewModel)DataContext;
                EmployeeViewModel dlgvm = (EmployeeViewModel)dlg.DataContext;

                vm.Employees.Add(dlgvm);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindowViewModel)DataContext).DeleteSelectedItem();
        }
    }
}
