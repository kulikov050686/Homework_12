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
        long? Number { get; }

        /// <summary>
        /// Серия
        /// </summary>
        long? Series { get; }

        /// <summary>
        /// Место выдачи
        /// </summary>
        string PlaceOfIssue { get; }

        /// <summary>
        /// Дата выпуска
        /// </summary>
        DateTime? DateOfIssue { get; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        DivisionCode DivisionCode { get; }

        /// <summary>
        /// Владелец
        /// </summary>
        IPerson Holder { get; }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемй объект </param>        
        bool Equals(IPassport obj)
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
