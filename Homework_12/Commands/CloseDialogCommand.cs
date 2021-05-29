using System.Windows;

namespace Commands
{
    /// <summary>
    /// Класс команда закрытия диалогового окна
    /// </summary>
    public class CloseDialogCommand : BaseCommand
    {
        public bool? DialogResult { get; set; }

        public override bool CanExecute(object parameter) => parameter is Window;
        
        public override void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;

            var window = (Window)parameter;
            window.DialogResult = DialogResult;
            window.Close();
        }
    }
}
