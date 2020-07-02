using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Phonebook
{
    public class MainViewModel
    {
        public ObservableCollection<PersonViewModel> Persons { get; set; } = new ObservableCollection<PersonViewModel>();

        private readonly string Path = "Persons.txt";

        public MainViewModel()
        {
            GetPersonsFromFile();
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

        public void AddPerson()
        {
            Persons.Add(new PersonViewModel { Name = "John", Surname = "Smith", Nickname = "JohnSmith", PhoneNumber = "89118765551"});
            File.AppendAllText(Path, $"{Environment.NewLine} John, Smith, JohnSmith, 89118765551,");
        }
    }
}