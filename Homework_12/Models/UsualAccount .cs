namespace Models
{
    /// <summary>
    /// Класс обычный счёт
    /// </summary>
    public class UsualAccount  : BankAccount
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public UsualAccount(BankCustomer bankCustomer) : base(bankCustomer)
        {
            AccountStatus = AccountStatus.USUAL;
        }
    }
}
