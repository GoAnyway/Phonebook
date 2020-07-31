using Phonebook.Models;
using System.Collections.Generic;

namespace Phonebook.DbManager
{
    public interface IDbPhonebookManager
    {
        IEnumerable<PersonViewModel> GetAll();
        void Save(PersonViewModel model);
    }
}