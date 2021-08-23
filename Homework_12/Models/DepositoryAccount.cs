using Enums;

namespace Models
{
    /// <summary>
    /// Класс Депозитный счёт
    /// </summary>
    public class DepositoryAccount : BankAccount
    {
        /// <summary>
        /// Статус депозита
        /// </summary>
        public DepositStatus DepositStatus { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        /// <param name="depositStatus"> Статус депозита </param>
        public DepositoryAccount(int id, DepositStatus depositStatus) : base(id, AccountStatus.DEPOSITORY)
        {
            DepositStatus = depositStatus;
        }
    }
}
