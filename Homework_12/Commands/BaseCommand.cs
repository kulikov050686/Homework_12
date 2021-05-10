using System;
using System.Windows.Input;

namespace Commands
{
    /// <summary>
    /// Базовый класс комманд
    /// </summary>
    public abstract class BaseCommand : ICommand
    {
        /// <summary>
        /// Событие извещающее об измении состояния команды
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested += value;
        }

        /// <summary>
        /// Вызов разрешающего метода команды
        /// </summary>
        /// <param name="parameter"> Параметр команды </param>        
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// Вызов выполняющего метода команды
        /// </summary>
        /// <param name="parameter"> Параметр команды </param>
        public abstract void Execute(object parameter);
    }
}
