using Phonebook.Entites;
using System;
using System.Collections.Generic;

namespace Phonebook
{
    public interface IPhonebookRepository : IDisposable
    {
        IEnumerable<Person> GetAll();
        void Save(Person person);
    }
}