using Phonebook.Models;
using System.Windows;

namespace Phonebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel MainViewModel = new MainViewModel(new FilePhonebookManager("Persons.txt"));
        public MainWindow()
        {
            InitializeComponent();
            DataContext = MainViewModel;
        }
    }
}