using Interfaces;
using System;

namespace Models
{
    /// <summary>
    /// Класс человек
    /// </summary>
    public class Person : IPerson
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; }

        /// <summary>
        /// Пол
        /// </summary>
        public string Gender { get; }

        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime Birthday { get; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string PlaceOfBirth { get; }

        /// <summary>
        /// Место жительства (прописка)
        /// </summary>
        public IAddress PlaceOfResidence { get; set; }

        /// <summary>
        /// Место регистрации (место непосредственного проживания)
        /// </summary>
        public IAddress PlaceOfRegistration { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="surname"> Фамилия </param>
        /// <param name="name"> Имя </param>
        /// <param name="patronymic"> Отчество </param>
        /// <param name="gender"> Пол </param>
        /// <param name="birthday"> День рождения </param>
        /// <param name="placeOfBirth"> Место рождения </param>
        /// <param name="placeOfResidence"> Место жительства (прописка) </param>
        /// <param name="placeOfRegistration"> Место регистрации </param>
        public Person(string surname,
                      string name,
                      string patronymic,
                      string gender,
                      DateTime birthday,
                      string placeOfBirth,
                      IAddress placeOfResidence,
                      IAddress placeOfRegistration = null)
        {
            if (string.IsNullOrWhiteSpace(surname)) 
                throw new ArgumentException("Фамилия не может быть пустой!!!");
            if (string.IsNullOrWhiteSpace(name)) 
                throw new ArgumentException("Имя не может быть пустым!!!");
            if (string.IsNullOrWhiteSpace(patronymic)) 
                throw new ArgumentException("Отчество не может быть пустым!!!");
            if (string.IsNullOrWhiteSpace(gender)) 
                throw new ArgumentException("Пол не может быть пустым!!!");
            if (string.IsNullOrWhiteSpace(placeOfBirth)) 
                throw new ArgumentException("Место рождения не может быть пустым!!!");
            if (placeOfResidence is null) 
                throw new ArgumentNullException("Адрес прописки не может быть null!!!");

            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            Birthday = birthday;
            PlaceOfBirth = placeOfBirth;
            PlaceOfResidence = placeOfResidence;
            PlaceOfRegistration = placeOfRegistration;
        }        
    }
}
