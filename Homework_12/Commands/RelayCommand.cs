using System;

namespace Commands
{
    /// <summary>
    /// Класс комманд
    /// </summary>
    public class RelayCommand : BaseCommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        
        /// <summary>
        /// Конструктор команды
        /// </summary>
        /// <param name="execute"> Выполняемый метод команды </param>
        /// <param name="canExecute"> Метод разрешающий выполнение команды </param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Вызов разрешающего метода команды
        /// </summary>
        /// <param name="parameter"> Параметр команды </param>        
        public override bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Вызов выполняющего метода команды
        /// </summary>
        /// <param name="parameter"> Параметр команды </param>
        public override void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;

            if (_execute != null)
            {
                _execute(parameter);
            }
        }
    }
}
