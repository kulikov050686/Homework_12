using System;

namespace Commands
{
    /// <summary>
    /// Класс комманд
    /// </summary>
    public class RelayCommand : BaseCommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
        
        /// <summary>
        /// Конструктор команды
        /// </summary>
        /// <param name="execute"> Выполняемый метод команды </param>
        /// <param name="canExecute"> Метод разрешающий выполнение команды </param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Вызов разрешающего метода команды
        /// </summary>
        /// <param name="parameter"> Параметр команды </param>        
        public override bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        /// <summary>
        /// Вызов выполняющего метода команды
        /// </summary>
        /// <param name="parameter"> Параметр команды </param>
        public override void Execute(object parameter)
        {
            if (execute != null)
            {
                this.execute(parameter);
            }
        }
    }
}
