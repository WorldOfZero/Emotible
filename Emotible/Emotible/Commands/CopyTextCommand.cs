using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Emotible.Commands
{
    public class CopyTextCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            float pi = 3.14f;
        }

        public event EventHandler CanExecuteChanged;
    }
}
