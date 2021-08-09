using Enums;

namespace Models
{
    /// <summary>
    /// Класс обычный счёт
    /// </summary>
    public class UsualAccount : BankAccount
    {
        /// <summary>
        /// Конструктор
        /// </summary>        
        public UsualAccount() : base(AccountStatus.USUAL) {}

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id"> Идентификатор </param>
        public UsualAccount(int id) : base(id, AccountStatus.USUAL) {}
    }
}
