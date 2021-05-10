using System;

namespace Models
{
    /// <summary>
    /// Класс человек
    /// </summary>
    public class Person
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
        public Address PlaceOfResidence { get; set; }

        /// <summary>
        /// Место регистрации (место непосредственного проживания)
        /// </summary>
        public Address PlaceOfRegistration { get; set; }

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
        public Person(string surname, 
                      string name, 
                      string patronymic, 
                      string gender, 
                      DateTime birthday, 
                      string placeOfBirth, 
                      Address placeOfResidence)
        {
            if(string.IsNullOrWhiteSpace(surname) || 
               string.IsNullOrWhiteSpace(name) || 
               string.IsNullOrWhiteSpace(patronymic) || 
               string.IsNullOrWhiteSpace(gender) || 
               string.IsNullOrWhiteSpace(placeOfBirth) ||
               placeOfResidence is null)
            {
                throw new ArgumentException("");
            }            

            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Gender = gender;
            Birthday = birthday;
            PlaceOfBirth = placeOfBirth;
            PlaceOfResidence = placeOfResidence;
            PlaceOfRegistration = placeOfResidence;
        }

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
                      Address placeOfResidence,
                      Address placeOfRegistration) : this(surname,
                                                          name,
                                                          patronymic,
                                                          gender,
                                                          birthday, 
                                                          placeOfBirth,
                                                          placeOfResidence)
        {
            if(placeOfRegistration is null) throw new ArgumentException("");
            
            PlaceOfRegistration = placeOfRegistration;
        }
    }
}
