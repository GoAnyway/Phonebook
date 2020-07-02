using Phonebook.Commands;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;

namespace Phonebook.Models
{
    public class MainViewModel
    {
        private readonly string Path = "Persons.txt";

        private PersonViewModel selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get => selectedPerson;
            set { selectedPerson = value; }
        }

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ObservableCollection<PersonViewModel> Persons { get; set; } = new ObservableCollection<PersonViewModel>();

        public MainViewModel()
        {
            GetPersonsFromFile();
            AddCommand = new AddCommand(this);
            DeleteCommand = new DeleteCommand(this);
        }

        public void GetPersonsFromFile()
        {
            FileInfo fileInf = new FileInfo(Path);

            if (fileInf.Exists)
            {
                string persons = File.ReadAllText(Path);
                persons = System.Text.RegularExpressions.Regex.Replace(persons, @"\s+", "");
                string[] person = persons.Split(',', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < person.Length; i += 4)
                {
                    Persons.Add(new PersonViewModel { Name = person[i], Surname = person[i + 1], Nickname = person[i + 2], PhoneNumber = person[i + 3] });
                }
            }

            else
                File.Create("Persons.txt");
        }
    }
}