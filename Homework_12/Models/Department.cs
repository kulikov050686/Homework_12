using Interfaces;
using System.Collections.Generic;

namespace Models
{
    /// <summary>
    /// Класс департамент
    /// </summary>
    public class Department<T> : IEntity 
        where T : BankCustomerBaseClass
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Лист клиентов банка
        /// </summary>
        public IList<T> BankCustomers { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="name"> Название </param>
        public Department(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <param name="name"> Название </param>
        public Department(int id, string name) : this(name)
        {            
            Id = id;
        }
    }
}
