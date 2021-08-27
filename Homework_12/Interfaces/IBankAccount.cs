using Enums;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс Банковский счёт
    /// </summary>
    public interface IBankAccount : IEntity
    {
        /// <summary>
        /// Сумма на счёте
        /// </summary>
        double? Amount { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        double? InterestRate { get; set; }

        /// <summary>
        /// Статус счёта
        /// </summary>
        AccountStatus AccountStatus { get; }

        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="obj"> Сравниваемый объект </param> 
        bool Equals(IBankAccount obj)
        {
            if (obj is null) return false;

            return (Id == obj.Id) && 
                   (Amount == obj.Amount) &&
                   (InterestRate == obj.InterestRate) &&
                   (AccountStatus == obj.AccountStatus);
        }
    }
}
