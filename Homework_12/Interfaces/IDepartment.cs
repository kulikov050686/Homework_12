using Enums;
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
        string Name { get; set; }

        /// <summary>
        /// Статус департамента
        /// </summary>
        Status StatusDepartment { get; set; }

        /// <summary>
        /// Лист клиентов банка
        /// </summary>
        IList<BankCustomer> BankCustomers { get; set; }
    }
}
