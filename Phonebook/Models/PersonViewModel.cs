using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Phonebook.Models
{
    public class PersonViewModel : INotifyPropertyChanged
    {
       private int id;
       public int Id
       {
           get => id;
           set { id = value; NotifyPropertyChanged(); }
       }

        private string name;
        public string Name 
        {
            get => name;
            set { name = value; NotifyPropertyChanged(); }
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set { surname = value; NotifyPropertyChanged(); }
        }

        private string nickname;
        public string Nickname 
        { 
            get => nickname; 
            set { nickname = value; NotifyPropertyChanged(); } 
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set { phoneNumber = value; NotifyPropertyChanged(); }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}