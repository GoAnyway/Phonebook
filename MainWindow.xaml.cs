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
            DataContext = MainViewModel;

            addButton.Tag = Action.Add;
            editButton.Tag = Action.Edit;
            deleteButton.Tag = Action.Delete;
        }

        private void ActionsButton_Click(object sender, RoutedEventArgs e)
        {
            Action action = (Action)((Button)sender).Tag;

            switch (action)
            {
                case Action.Add:
                    //personesList.Items.Add(new Person { Name = "555", Surname = "666", Nickname = "rad", PhoneNumber = "900001" });
                    break;

                case Action.Edit:
                    break;

                case Action.Delete:
                    //personesList.Items.Remove(personesList.SelectedItem);
                    break;
            }
        }
    }
}