using System.ComponentModel;
using System.Windows;

namespace Views
{
    public partial class AddDescriptionWindow : Window
    {
        #region Описание

        public static readonly DependencyProperty DescriptionProperty =
           DependencyProperty.Register(nameof(Description),
                                       typeof(string),
                                       typeof(AddDescriptionWindow),
                                       new PropertyMetadata(default(string)));

        [Description("Описание")]
        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        #endregion

        public AddDescriptionWindow() => InitializeComponent();       
    }
}
