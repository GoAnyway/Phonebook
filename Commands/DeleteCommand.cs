using System;
using System.Windows.Input;

namespace Phonebook.Commands
{
    public class DeleteCommand : ICommand
    {
        private readonly MainViewModel _model;
        public DeleteCommand(MainViewModel model)
        {
            _model = model;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            _model.Persons.Remove(_model.SelectedPerson);
        }
        public event EventHandler CanExecuteChanged;
    }
}