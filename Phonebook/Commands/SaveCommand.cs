using Phonebook.Models;
using System;

namespace Phonebook.Commands
{
    public class SaveCommand
    {
        private readonly MainViewModel _model;
        public SaveCommand(MainViewModel model)
        {
            _model = model;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            //
        }
        public event EventHandler CanExecuteChanged;
    }
}