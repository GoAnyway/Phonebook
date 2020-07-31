using Phonebook.Entites;
using Phonebook.Models;

namespace Phonebook
{
    public class PersonMapper : AbstractMapper<Person, PersonViewModel>
    {
        public override PersonViewModel MapTo(Person source)
        {
            return new PersonViewModel
            {
                Id = source.Id,
                Name = source.Name,
                Surname = source.Surname,
                Nickname = source.Nickname,
                PhoneNumber = source.PhoneNumber  
            };
        }
        public override Person MapFrom(PersonViewModel destination)
        {
            return new Person
            {
                Id = destination.Id,
                Name = destination.Name,
                Surname = destination.Surname,
                Nickname = destination.Nickname,
                PhoneNumber = destination.PhoneNumber
            };
        }
    }
}
