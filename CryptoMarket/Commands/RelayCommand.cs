using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoMarket.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object> _Excute { get; set; }
        private Predicate<object> _CanExcute { get; set; }
        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {
            _Excute = ExcuteMethod;
            _CanExcute = CanExcuteMethod;
        }
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            //throw new NotImplementedException();
            return _CanExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            //throw new NotImplementedException();
            _Excute(parameter);
        }
    }
}
