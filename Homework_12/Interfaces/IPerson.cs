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
        string Surname { get; }

        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Отчество
        /// </summary>
        string Patronymic { get; }

        /// <summary>
        /// Пол
        /// </summary>
        string Gender { get; }

        /// <summary>
        /// День рождения
        /// </summary>
        DateTime Birthday { get; }

        /// <summary>
        /// Место рождения
        /// </summary>
        string PlaceOfBirth { get; }

        /// <summary>
        /// Место жительства (прописка)
        /// </summary>
        IAddress PlaceOfResidence { get; set; }

        /// <summary>
        /// Место регистрации (место непосредственного проживания)
        /// </summary>
        IAddress PlaceOfRegistration { get; set; }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемый объект </param>        
        bool Equals(IPerson obj)
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
