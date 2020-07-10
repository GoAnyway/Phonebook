using Phonebook.Models;
using System.Windows;

namespace Phonebook
{
    public partial class MainWindow : Window
    {
        private MainViewModel MainViewModel = new MainViewModel(new FilePhonebookManager());
        public MainWindow()
        {
            InitializeComponent();
            DataContext = MainViewModel;
        }
    }
}