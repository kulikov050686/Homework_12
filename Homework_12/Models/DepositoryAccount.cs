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
        DepositStatus DepositStatus { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        /// <param name="depositStatus"> Статус депозита </param>
        public DepositoryAccount(DepositStatus depositStatus) : base(AccountStatus.DEPOSITORY)
        {
            DepositStatus = depositStatus;
        }
    }
}
