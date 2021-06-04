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
        public int Number { get; }

        /// <summary>
        /// Серия
        /// </summary>
        public int Series { get; }

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
    }
}
