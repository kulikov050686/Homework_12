using Interfaces;
using System;

namespace Models
{
    /// <summary>
    /// Класс место жительства
    /// </summary>
    public class Address : IAddress
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
        /// Конструктор
        /// </summary>
        /// <param name="registrationDate"> Дата регистрации </param>
        /// <param name="region"> Регион или Область </param>
        /// <param name="city"> Город </param>
        /// <param name="street"> Улица </param>
        /// <param name="houseNumber"> Дом </param>
        public Address(DateTime registrationDate,
                       string region,
                       string city,
                       string street,
                       int houseNumber)
        {
            if(string.IsNullOrWhiteSpace(region)) throw new ArgumentException("Регион или область не может быть пустым!!!");
            if(string.IsNullOrWhiteSpace(city)) throw new ArgumentException("Город не может быть пустым!!!");
            if(string.IsNullOrWhiteSpace(street)) throw new ArgumentException("Улица не может быть пустой!!!");
            if (houseNumber <= 0) throw new ArgumentException("Номер дома не верен!!!");

            RegistrationDate = registrationDate;
            Region = region;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="registrationDate"> Дата регистрации </param>
        /// <param name="region"> Регион или Область </param>
        /// <param name="city"> Город </param>
        /// <param name="street"> Улица </param>
        /// <param name="houseNumber"> Дом </param>
        /// <param name="apartmentNumber"> Номер квартиры </param>        
        public Address(DateTime registrationDate,
                       string region,
                       string city,
                       string street,
                       int houseNumber,
                       int apartmentNumber) : this(registrationDate,
                                                   region,
                                                   city,
                                                   street,
                                                   houseNumber)
        {
            if(apartmentNumber <= 0) throw new ArgumentException("Номер квартиры не верен!!!");
            ApartmentNumber = apartmentNumber;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="registrationDate"> Дата регистрации </param>
        /// <param name="region"> Регион или Область </param>
        /// <param name="city"> Город </param>
        /// <param name="street"> Улица </param>
        /// <param name="houseNumber"> Дом </param>
        /// <param name="apartmentNumber"> Номер квартиры </param>
        /// <param name="housing"> Корпус дома </param>        
        public Address(DateTime registrationDate,
                       string region,
                       string city,
                       string street,
                       int houseNumber,
                       int apartmentNumber,
                       string housing) : this(registrationDate,
                                              region,
                                              city,
                                              street,
                                              houseNumber, 
                                              apartmentNumber)
        {
            if(string.IsNullOrWhiteSpace(housing)) throw new ArgumentException("Корпус дома не может быть пустым!!!");
            Housing = housing;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="registrationDate"> Дата регистрации </param>
        /// <param name="region"> Регион или Область </param>
        /// <param name="city"> Город </param>
        /// <param name="street"> Улица </param>
        /// <param name="houseNumber"> Дом </param>
        /// <param name="apartmentNumber"> Номер квартиры </param>
        /// <param name="housing"> Корпус дома </param>
        /// <param name="district"> Район города </param>
        public Address(DateTime registrationDate,
                       string region,
                       string city,
                       string street,
                       int houseNumber,
                       int apartmentNumber,
                       string housing,
                       string district) : this(registrationDate,
                                               region,
                                               city,
                                               street,
                                               houseNumber,
                                               apartmentNumber,
                                               housing)
        {
            if (string.IsNullOrWhiteSpace(district)) throw new ArgumentException("Район города не может быть пустым!!!");
            District = district;
        }
    }
}
