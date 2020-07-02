namespace Phonebook
{
    public class PersonViewModel
    {
        public PersonViewModel(string name, string surname, string nickname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public string PhoneNumber { get; set; }
    }
}