using Enums;

namespace Models
{
    /// <summary>
    /// Класс кредитный счёт
    /// </summary>
    public class CreditAccount : BankAccount
    {
        /// <summary>
        /// Статус кредита
        /// </summary>
        public CreditStatus CreditStatus { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        /// <param name="creditStatus"> Статус кредита </param>
        public CreditAccount(BankCustomer bankCustomer, CreditStatus creditStatus) : base(bankCustomer)
        {
            AccountStatus = AccountStatus.CREDIT;
            CreditStatus = creditStatus;
        }
    }
}
