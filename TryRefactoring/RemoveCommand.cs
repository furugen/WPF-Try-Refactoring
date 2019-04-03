using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TryRefactoring
{
    public class RemoveCommand : ICommand
    {
        public bool CanExecute(object parameter) { return true; }
        public event EventHandler CanExecuteChanged;

        private MainWindowViewModel vm;

        public RemoveCommand(MainWindowViewModel viewModel)
        {
            this.vm = viewModel;
        }
        public void Execute(object parameter)
        {
            this.vm.OnRemoveRecord();
        }
    }
}
