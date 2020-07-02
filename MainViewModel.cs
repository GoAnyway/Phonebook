using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;

namespace Phonebook
{
    public class MainViewModel
    {
        public ObservableCollection<PersonViewModel> Persons { get; set; } = new ObservableCollection<PersonViewModel>();
        
        public MainViewModel()
        {
            ReadFromFile();
        }

        public void ReadFromFile()
        {
            string path = "Persons.txt";
            FileInfo fileInf = new FileInfo(path);

            if (fileInf.Exists)
            {
                using (Stream readingStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    string persons = File.ReadAllText(path);
                    persons = persons.Replace(Environment.NewLine, " ");
                    string[] person = persons.Split(',', StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < person.Length; i += 4)
                    {
                        Persons.Add(new PersonViewModel(person[i], person[i + 1], person[i + 2], person[i + 3]));
                        //MessageBox.Show($"{person[i]}, {person[i+1]}, {person[i+2]}, {person[i+3]}");
                    }
                }
            }
        }
    }
}