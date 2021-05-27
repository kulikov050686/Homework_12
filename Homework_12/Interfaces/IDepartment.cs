using System.Collections.Generic;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс департамент
    /// </summary>    
    public interface IDepartment<IBankCustomer> : IEntity
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Лист клиентов банка
        /// </summary>
        public IList<IBankCustomer> BankCustomers { get; set; }
    }
}
