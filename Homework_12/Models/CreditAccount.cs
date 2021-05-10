namespace Models
{
    /// <summary>
    /// Класс кредитный счёт
    /// </summary>
    class CreditAccount : BankAccountBaseClass
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
        public CreditAccount(BankCustomerBaseClass bankCustomer, CreditStatus creditStatus) : base(bankCustomer)
        {
            AccountStatus = AccountStatus.CREDIT;
            CreditStatus = creditStatus;
        }
    }
}
