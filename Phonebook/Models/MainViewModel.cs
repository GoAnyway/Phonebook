using Phonebook.Commands;
using Phonebook.Context;
using Phonebook.DbManager;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Phonebook.Models
{
    public class MainViewModel 
    {
        private readonly DbPhonebookManager _manager = new DbPhonebookManager(new PhonebookRepository(new PersonContext()), new PersonMapper());

        private readonly PersonViewModel _personView = new PersonViewModel();

        private PersonViewModel _selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get => _selectedPerson;
            set { _selectedPerson = value; }
        }

        public ObservableCollection<PersonViewModel> Persons { get; set; } = new ObservableCollection<PersonViewModel>();

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public MainViewModel()
        {
            Persons.CollectionChanged += (sender, args) => { _manager.Save(_personView); };

            var persons = _manager.GetAll();

            foreach (var person in persons)
            {
                Persons.Add(person);
            }

            AddCommand = new AddCommand(this);
            DeleteCommand = new DeleteCommand(this);
            SaveCommand = new SaveCommand(this, _manager);
        }
    }
}