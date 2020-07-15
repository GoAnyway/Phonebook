using Phonebook.Commands;
using Phonebook.DbManager;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Phonebook.Models
{
    public class MainViewModel 
    {       
        private PersonViewModel _selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get => _selectedPerson;
            set { _selectedPerson = value; }
        }

        private IPhonebookManager _loader;

        public ObservableCollection<PersonViewModel> Persons { get; set; } = new ObservableCollection<PersonViewModel>();

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public MainViewModel(IPhonebookManager loader)
        {
            _loader = loader;

            Persons.Clear();
            foreach (var entry in _loader.Get())
            {
                Persons.Add(entry);
            }

            AddCommand = new AddCommand(this);
            DeleteCommand = new DeleteCommand(this);
            SaveCommand = new SaveCommand(this, new DbPhonebookManager());
        }
    }
}