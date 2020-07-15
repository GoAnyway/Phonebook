using Phonebook.Entites;
using Phonebook.Models;
using Phonebook.Context;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Phonebook.DbManager
{
    public class DbPhonebookManager : IPhonebookManager
    {
        public IEnumerable<PersonViewModel> Get()
        {
            var result = new List<PersonViewModel>();

            using (PersonContext DB = new PersonContext())
            {
                var persons = DB.Persons;
                foreach (Person p in persons)
                {
                    result.Add(new PersonViewModel { Id = p.Id, Name = p.Name, Surname = p.Surname, Nickname = p.Nickname, PhoneNumber = p.PhoneNumber });
                }
            }

            return result;
        }

        public void Set(ObservableCollection<PersonViewModel> persons)
        {
            using (PersonContext DB = new PersonContext())
            {
                DB.Persons.RemoveRange(DB.Persons);

                foreach (var p in persons)
                {
                    DB.Persons.Add(new Person { Name = p.Name, Surname = p.Surname, Nickname = p.Nickname, PhoneNumber = p.PhoneNumber });
                    DB.SaveChanges();
                }
            }
        }
    }
}