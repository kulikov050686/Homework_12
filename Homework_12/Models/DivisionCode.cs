using System;

namespace Models
{
    /// <summary>
    /// Класс код подразделения
    /// </summary>
    public class DivisionCode
    {
        /// <summary>
        /// Левая часть кода подразделения
        /// </summary>
        public int Left { get; }
        
        /// <summary>
        /// Правая часть кода подразделения
        /// </summary>
        public int Right { get; }
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="left"> Левая часть кода </param>
        /// <param name="right"> Правая часть кода </param>
        public DivisionCode(int left, int right)
        {
            if (left <= 0) throw new ArgumentException("Невозможное значение!!!");
            Left = left;

            if (right <= 0) throw new ArgumentException("Невозможное значение!!!");
            Right = right;
        }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемй объект </param>
        public bool Equals(DivisionCode obj)
        {
            if (obj is null) 
                throw new ArgumentNullException(nameof(obj));

            return Left == obj.Left &&
                   Right == obj.Right;
        }
    }
}
