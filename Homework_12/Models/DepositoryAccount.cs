namespace Models
{
    /// <summary>
    /// Класс Депозитный счёт
    /// </summary>
    public class DepositoryAccount : BankAccountBaseClass
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
        public DepositoryAccount(BankCustomerBaseClass bankCustomer, DepositStatus depositStatus) : base(bankCustomer)
        {
            AccountStatus = AccountStatus.DEPOSITORY;
            DepositStatus = depositStatus;
        }
    }
}
