using System;

namespace Models
{
    /// <summary>
    /// Класс код подразделения
    /// </summary>
    public class DivisionCode
    {
        int _left;
        int _right;

        /// <summary>
        /// Левая часть кода подразделения
        /// </summary>
        public int Left
        {
            get => _left;

            set
            {
                if(100 > value || value > 999) 
                    throw new ArgumentException("Выход из диапазона!!!");

                _left = value;
            }
        }

        /// <summary>
        /// Правая часть кода подразделения
        /// </summary>
        public int Right
        {
            get => _right;

            set 
            {
                if (100 > value || value > 999)
                    throw new ArgumentException("Выход из диапазона!!!");

                _right = value;
            } 
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public DivisionCode()
        {
            _left = 100;
            _right = 999;
        }
    }
}
