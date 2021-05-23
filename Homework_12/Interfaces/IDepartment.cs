using System.Collections.Generic;

namespace Interfaces
{
    public interface IDepartment<T> : IEntity 
        where T : IBankCustomer
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Лист клиентов банка
        /// </summary>
        public IList<T> BankCustomers { get; set; }
    }
}
