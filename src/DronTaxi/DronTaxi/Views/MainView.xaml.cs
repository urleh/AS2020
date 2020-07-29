using Catel.Windows;
using DronTaxi.ViewModels;
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

namespace DronTaxi.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainView : DataWindow
    {
        public MainView(): base(DataWindowMode.Custom)
        {
            InitializeComponent();

            CanCloseUsingEscape = false;
        }

        public MainView(MainViewModel viewModel) : base(viewModel, DataWindowMode.Custom)
        {
            InitializeComponent();
        }
    }
}
