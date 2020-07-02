using Phonebook.Models;
using System.Collections.Generic;

namespace Phonebook
{
    public interface IPhonebookManager
    {
        IEnumerable<PersonViewModel> Get();
    }
}