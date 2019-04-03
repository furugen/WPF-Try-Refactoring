using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TryRefactoring
{
    public class AddCommand : ICommand
    {
        public bool CanExecute(object parameter) { return true; }
        public event EventHandler CanExecuteChanged;

        private MainWindowViewModel vm;

        public AddCommand(MainWindowViewModel viewModel)
        {
            this.vm = viewModel;
        }
        public void Execute(object parameter)
        {
            this.vm.OnAddRecord();
        }
    }
}
