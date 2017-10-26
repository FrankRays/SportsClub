using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SportsClub.UI.Common
{
    class Command : ICommand
    {
        private Action targetMethod;
        private Func<bool> targetCanExecuteMethod;

        public event EventHandler CanExecuteChanged;

        public Command(Action targetMethod)
        {
            this.targetMethod = targetMethod;
        }

        public Command(Action targetMethod, Func<bool> targetCanExecuteMethod) : this(targetMethod)
        {
            this.targetCanExecuteMethod = targetCanExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            return targetCanExecuteMethod != null ? targetCanExecuteMethod() : targetMethod != null;
        }

        public void Execute(object parameter)
        {
            targetMethod?.Invoke();
        }
    }
}
