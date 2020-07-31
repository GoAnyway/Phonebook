using Phonebook.Entites;
using Phonebook.Models;
using System.Collections.Generic;

namespace Phonebook.DbManager
{
    public class DbPhonebookManager : IDbPhonebookManager
    {
        private readonly IPhonebookRepository _repository;

        private readonly AbstractMapper<Person, PersonViewModel> _mapper;

        public DbPhonebookManager(IPhonebookRepository repository, AbstractMapper<Person, PersonViewModel> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<PersonViewModel> GetAll()
        {
            foreach (var person in _repository.GetAll())
            {
                yield return _mapper.MapTo(person);
            }
        }

        public void Save(PersonViewModel model)
        {
            _repository.Save(_mapper.MapFrom(model));
        }
    }
}