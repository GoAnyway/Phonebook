using Phonebook.Models;
using System;
using System.Windows.Input;

namespace Phonebook.Commands
{
    public class AddCommand : ICommand
    {
        private readonly MainViewModel _model;
        public AddCommand(MainViewModel model)
        {
            _model = model;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }
        
        public void Execute(object parameter)
        {
            _model.Persons.Add(new PersonViewModel { });
        }

#pragma warning disable CS0067
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067
    }
}
