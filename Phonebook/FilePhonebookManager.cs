using Phonebook.Models;
using System.Collections.Generic;

namespace Phonebook
{
    public class FilePhonebookManager : IPhonebookManager
    {
        public IEnumerable<PersonViewModel> Get()
        {
            var result = new List<PersonViewModel>();

            using (AppContext DB = new AppContext())
            {
                var persons = DB.Persons;
                foreach (Person p in persons)
                {
                    result.Add(new PersonViewModel { Name = p.Name, Surname = p.Surname, Nickname = p.Nickname, PhoneNumber = p.PhoneNumber });
                }
            }

            return result;
        }
    }
}