using System.Windows;
using System.Windows.Controls;

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
            personesData.ItemsSource = MainViewModel.Persons;

            addButton.Tag = Action.Add;
            deleteButton.Tag = Action.Delete;
        }

        private void ActionsButton_Click(object sender, RoutedEventArgs e)
        {
            Action action = (Action)((Button)sender).Tag;

            switch (action)
            {
                case Action.Add: 
                    MainViewModel.AddPerson();
                    break;

                case Action.Delete:
                    MainViewModel.Persons.Remove((PersonViewModel)personesData.SelectedItem);
                    break;
            }
        }
    }
}