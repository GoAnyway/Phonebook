using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Phonebook
{
    public class FilePhonebookManager : IPhonebookManager
    {
        private readonly string _filename = "Persons.txt";

        public FilePhonebookManager(string filename)
        {
            _filename = filename;
            Get();
        }

        public IEnumerable<PersonViewModel> Get()
        {
            var result = new List<PersonViewModel>();  
            FileInfo fileInf = new FileInfo(_filename);

            if (fileInf.Exists)
            {
                string persons = File.ReadAllText(_filename);
                persons = System.Text.RegularExpressions.Regex.Replace(persons, @"\s+", "");
                string[] person = persons.Split(',', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < person.Length; i += 4)
                {
                    result.Add(new PersonViewModel { Name = person[i], Surname = person[i + 1], Nickname = person[i + 2], PhoneNumber = person[i + 3] });
                }
            }

            else
                File.Create("Persons.txt");

            return result;

        }
    }
}