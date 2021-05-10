using System.Windows.Media;

namespace System.Windows
{
    /// <summary>
    /// Класс расширения
    /// </summary>
    public static class DependencyObjectExtensions
    {
        /// <summary>
        /// Поиск родителя в визуальном дереве
        /// </summary>               
        public static DependencyObject FindVisualRoot(this DependencyObject obj)
        {
            do
            {
                var parent = VisualTreeHelper.GetParent(obj);
                if (parent is null) return obj;
                obj = parent;
            } while (true);
        }

        /// <summary>
        /// Поиск родителя в логическом дереве
        /// </summary>             
        public static DependencyObject FindLogicalRoot(this DependencyObject obj)
        {
            do
            {
                var parent = LogicalTreeHelper.GetParent(obj);
                if (parent is null) return obj;
                obj = parent;
            } while (true);
        }

        /// <summary>
        /// Поиск родительского элемента нужного типа в визуальном дереве
        /// </summary>
        /// <typeparam name="T"> Тип родительского элемента </typeparam>        
        public static T FindVisualParent<T>(this DependencyObject obj) where T : DependencyObject
        {
            if (obj is null) return null;

            var target = obj;

            do
            {
                target = VisualTreeHelper.GetParent(target);
            } while (target != null && !(target is T));

            return target as T;
        }

        /// <summary>
        /// Поиск родительского элемента нужного типа в логическом дереве
        /// </summary>
        /// <typeparam name="T"> Тип родительского элемента </typeparam>
        public static T FindLogicalParent<T>(this DependencyObject obj) where T : DependencyObject
        {
            if (obj is null) return null;

            var target = obj;

            do
            {
                target = LogicalTreeHelper.GetParent(target);
            } while (target != null && !(target is T));

            return target as T;
        }
    }
}
