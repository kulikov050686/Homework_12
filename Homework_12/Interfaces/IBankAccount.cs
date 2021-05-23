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
        public double Amount { get; set; }

        /// <summary>
        /// Процентная ставка
        /// </summary>
        public double InterestRate { get; set; }

        /// <summary>
        /// Статус счёта
        /// </summary>
        public AccountStatus AccountStatus { get; }
    }
}
