using Phonebook.DbManager;
using Phonebook.Models;
using System;
using System.Windows.Input;

namespace Phonebook.Commands
{
    public class SaveCommand : ICommand
    {
        private readonly IDbPhonebookManager _keeper;

        private readonly PersonViewModel _personModel = new PersonViewModel();

        private readonly MainViewModel _model;

        public SaveCommand(MainViewModel model, IDbPhonebookManager keeper)
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
            _keeper.Save(_personModel);
        }

#pragma warning disable CS0067
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067
    }
}