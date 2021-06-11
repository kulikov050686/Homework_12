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
        double Amount { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        double InterestRate { get; set; }

        /// <summary>
        /// Статус счёта
        /// </summary>
        AccountStatus AccountStatus { get; }
    }
}
