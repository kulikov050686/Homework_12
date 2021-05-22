using System;
using System.Windows;
using Views;

namespace Commands
{
    /// <summary>
    /// Команда открытия окна заполнения данных клиента банка
    /// </summary>
    class BankCustomersManagementCommand : BaseCommand
    {
        private BankCustomersManagementWindow _window;

        /// <summary>
        /// Разрешающий метод выполнения команды
        /// </summary>
        /// <param name="parameter"></param>        
        public override bool CanExecute(object parameter) => _window == null;
        
        /// <summary>
        /// Выполняющий метод
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object parameter)
        {
            var window = new BankCustomersManagementWindow
            {
                Owner = Application.Current.MainWindow
            };

            _window = window;
            window.Closed += OnWindowClosed;

            window.ShowDialog();
        }

        /// <summary>
        /// Обработчик события закрытия окна
        /// </summary>        
        private void OnWindowClosed(object sender, EventArgs e)
        {
            ((Window)sender).Closed -= OnWindowClosed;
            _window = null;
        }
    }
}
