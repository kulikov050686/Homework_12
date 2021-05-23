namespace Interfaces
{
    /// <summary>
    /// Интерфейс Клиет Банка
    /// </summary>
    public interface IBankCustomer : IEntity
    {
        /// <summary>
        /// Паспорт
        /// </summary>
        public IPassport Passport { get; set; }

        /// <summary>
        /// Надёжность
        /// </summary>
        public byte Reliability { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }        
    }
}
