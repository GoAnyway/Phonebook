using Phonebook.DbManager;
using Phonebook.Models;
using System;
using System.Windows.Input;

namespace Phonebook.Commands
{
    public class SaveCommand : ICommand
    {
        private readonly IPhonebookManager _keeper;

        private readonly MainViewModel _model;
        public SaveCommand(MainViewModel model, IPhonebookManager keeper)
        {
            _model = model;
            _keeper = keeper;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
           _keeper.Set(_model.Persons);
        }

#pragma warning disable CS0067
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067
    }
}