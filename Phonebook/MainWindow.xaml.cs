using Phonebook.Models;
using System.Windows;

namespace Phonebook
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel _mainViewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainViewModel;
        }
    }
}