using Phonebook.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Phonebook.DbManager
{
    public interface IPhonebookManager
    {
        IEnumerable<PersonViewModel> Get();
        void Set(ObservableCollection<PersonViewModel> persons);
    }
}