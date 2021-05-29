using Models;
using System.Collections.Generic;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс департамент
    /// </summary>    
    public interface IDepartment : IEntity
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Лист клиентов банка
        /// </summary>
        public IList<BankCustomer> BankCustomers { get; set; }
    }
}
