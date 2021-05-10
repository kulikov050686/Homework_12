using System;

namespace Models
{
    /// <summary>
    /// Класс паспорт
    /// </summary>
    public class Passport
    {
        /// <summary>
        /// Номер
        /// </summary>
        public ulong Number { get; }
        
        /// <summary>
        /// Серия
        /// </summary>
        public ulong Series { get; }

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
        public ulong DivisionCode { get; }

        /// <summary>
        /// Владелец
        /// </summary>
        public Person Holder { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="series"> Серия </param>
        /// <param name="number"> Номер </param>
        /// <param name="placeOfIssue"> Место выдачи </param>
        /// <param name="dateOfIssue"> Дата выпуска </param>
        /// <param name="divisionCode"> Код подразделения </param>
        /// <param name="holder"> Владелец </param>
        public Passport(ulong series, 
                        ulong number, 
                        string placeOfIssue, 
                        DateTime dateOfIssue, 
                        ulong divisionCode, 
                        Person holder)
        {
            if(holder is null) throw new ArgumentException("Владелец не может быть null!!!");
            if(string.IsNullOrWhiteSpace(placeOfIssue)) throw new ArgumentException("Место выдачи не может быть null!!!");

            Series = series;
            Number = number;
            PlaceOfIssue = placeOfIssue;
            DateOfIssue = dateOfIssue;
            DivisionCode = divisionCode;
            Holder = holder;
        }

        /// <summary>
        /// Изменить место жительства (прописка)
        /// </summary>
        /// <param name="newPlaceOfResidence"> Новое место жительства (прописка) </param>
        public void EditPlaceOfResidence(Address newPlaceOfResidence)
        {
            if(newPlaceOfResidence is null) throw new ArgumentException("Новый адрес не может быть null!!!");
            
            Holder.PlaceOfResidence = newPlaceOfResidence;
        }

        /// <summary>
        /// Изменить место регистрации
        /// </summary>
        /// <param name="newPlaceOfRegistration"> Новое место регистрации </param>
        public void EditPlaceOfRegistration(Address newPlaceOfRegistration)
        {
            if(newPlaceOfRegistration is null) throw new ArgumentException("Новый адрес не может быть null!!!");
            
            Holder.PlaceOfRegistration = newPlaceOfRegistration;
        }
    }
}
