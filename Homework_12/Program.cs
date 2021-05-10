using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_12
{
    public static class Program
    {
        /// <summary>
        /// Точка входа в приложение
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
