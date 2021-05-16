using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace UserControls
{    
    public partial class FotoUserControl : UserControl
    {
        #region Название

        public static readonly DependencyProperty TitleUCProperty =
           DependencyProperty.Register(nameof(TitleUC),
                                       typeof(string),
                                       typeof(FotoUserControl),
                                       new PropertyMetadata(default(string)));

        [Description("Название")]
        public string TitleUC
        {
            get => (string)GetValue(TitleUCProperty);
            set => SetValue(TitleUCProperty, value);
        }

        #endregion

        #region Изображение

        public static readonly DependencyProperty ImageSourceUCProperty =
           DependencyProperty.Register(nameof(ImageSourceUC),
                                       typeof(ImageSource),
                                       typeof(FotoUserControl),
                                       new PropertyMetadata(default(ImageSource)));

        [Description("Изображение")]
        public ImageSource ImageSourceUC
        {
            get => (ImageSource)GetValue(ImageSourceUCProperty);
            set => SetValue(ImageSourceUCProperty, value);
        }

        #endregion

        #region Команда добавить

        public static readonly DependencyProperty CommandReviewUCProperty =
           DependencyProperty.Register(nameof(CommandReviewUC),
                                       typeof(ICommand),
                                       typeof(FotoUserControl),
                                       new PropertyMetadata(default(ICommand)));

        [Description("Команда добавить")]
        public ICommand CommandReviewUC
        {
            get => (ICommand)GetValue(CommandReviewUCProperty);
            set => SetValue(CommandReviewUCProperty, value);
        }

        #endregion

        public FotoUserControl() => InitializeComponent();        
    }
}
