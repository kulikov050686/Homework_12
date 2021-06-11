using System;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс человек
    /// </summary>
    public interface IPerson
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
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемый объект </param>        
        public bool Equals(IPerson obj)
        {
            if (obj is null) return false;

            return Surname == obj.Surname &&
                   Name == obj.Name &&
                   Patronymic == obj.Patronymic &&
                   Gender == obj.Gender &&
                   Birthday == obj.Birthday &&
                   PlaceOfBirth == obj.PlaceOfBirth &&
                   PlaceOfResidence.Equals(obj.PlaceOfResidence) &&
                   PlaceOfRegistration.Equals(obj.PlaceOfRegistration);
        } 
    }
}
