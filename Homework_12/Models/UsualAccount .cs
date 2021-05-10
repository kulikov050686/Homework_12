namespace Models
{
    /// <summary>
    /// Класс обычный счёт
    /// </summary>
    public class UsualAccount  : BankAccountBaseClass
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public UsualAccount(BankCustomerBaseClass bankCustomer) : base(bankCustomer)
        {
            AccountStatus = AccountStatus.USUAL;
        }
    }
}
