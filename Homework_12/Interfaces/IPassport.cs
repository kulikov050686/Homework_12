using Models;
using System;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс паспорт
    /// </summary>
    public interface IPassport
    {
        /// <summary>
        /// Номер
        /// </summary>
        public long Number { get; }

        /// <summary>
        /// Серия
        /// </summary>
        public long Series { get; }

        /// <summary>
        /// Место выдачи
        /// </summary>
        public string PlaceOfIssue { get; }

        /// <summary>
        /// Дата выпуска
        /// </summary>
        public DateTime DateOfIssue { get; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        public DivisionCode DivisionCode { get; }

        /// <summary>
        /// Владелец
        /// </summary>
        public IPerson Holder { get; }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемй объект </param>        
        public bool Equals(IPassport obj)
        {
            if (obj is null) return false;

            return Number == obj.Number &&
                   Series == obj.Series &&
                   PlaceOfIssue == obj.PlaceOfIssue &&
                   DateOfIssue == obj.DateOfIssue &&
                   DivisionCode.Equals(obj.DivisionCode) &&
                   Holder.Equals(obj.Holder);
        }
    }
}
