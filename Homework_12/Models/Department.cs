using System.Collections.ObjectModel;

namespace Models
{
    /// <summary>
    /// Класс департамент
    /// </summary>
    public class Department<T> where T : BankCustomerBaseClass
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Лист клиентов банка
        /// </summary>
        public ObservableCollection<T> BankCustomers { get; set; }

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
        public Department(ulong id, string name) : this(name)
        {            
            Id = id;
        }
    }
}
