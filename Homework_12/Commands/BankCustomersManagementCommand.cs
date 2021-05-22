using System;
using System.Windows;
using Views;

namespace Commands
{
    class BankCustomersManagementCommand : BaseCommand
    {
        private BankCustomersManagementWindow _window;

        public override bool CanExecute(object parameter) => _window == null;
        
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

        private void OnWindowClosed(object sender, EventArgs e)
        {
            ((Window)sender).Closed -= OnWindowClosed;
            _window = null;
        }
    }
}
