using Phonebook.DbManager;
using Phonebook.Models;
using System.Windows;

namespace Phonebook
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel MainViewModel = new MainViewModel(new DbPhonebookManager());
        public MainWindow()
        {
            InitializeComponent();
            DataContext = MainViewModel;
        }
    }
}