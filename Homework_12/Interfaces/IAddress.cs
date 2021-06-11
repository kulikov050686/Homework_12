using System;

namespace Interfaces
{
    /// <summary>
    /// Интерейс адрес
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// Дата регистрации
        /// </summary>
        public DateTime RegistrationDate { get; }

        /// <summary>
        /// Область или регион
        /// </summary>
        public string Region { get; }

        /// <summary>
        /// Название города
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Район города
        /// </summary>
        public string District { get; }

        /// <summary>
        /// Название улицы
        /// </summary>
        public string Street { get; }

        /// <summary>
        /// Номер дома
        /// </summary>
        public int HouseNumber { get; }

        /// <summary>
        /// Корпус дома
        /// </summary>
        public string Housing { get; }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        public int ApartmentNumber { get; }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемый объект </param>        
        public bool Equals(IAddress obj)
        {
            if (obj is null) return false;

            return RegistrationDate == obj.RegistrationDate &&
                   Region == obj.Region &&
                   City == obj.City &&
                   District == obj.District &&
                   Street == obj.Street &&
                   HouseNumber == obj.HouseNumber &&
                   Housing == obj.Housing &&
                   ApartmentNumber == obj.ApartmentNumber;
        }
    }
}
