using Phonebook.Context;
using Phonebook.Entites;
using System;
using System.Collections.Generic;

namespace Phonebook
{
    public class PhonebookRepository : IPhonebookRepository
    {
        private readonly PersonContext _context;

        private bool _isDisposed = false;

        public PhonebookRepository(PersonContext context)
        {
            _context = context;
        }

        public IEnumerable<Person> GetAll() => _context.Set<Person>();

        public void Save(Person person)
        {
            _context.Set<Person>().Add(person);
            //_context.SaveChanges();
            //_context.Dispose();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _isDisposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}