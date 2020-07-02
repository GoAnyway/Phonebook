using Phonebook.Models;
using System.Windows;

namespace Phonebook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel MainViewModel { get; set; } = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = MainViewModel;
        }
    }
}