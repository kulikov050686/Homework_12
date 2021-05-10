namespace Models
{
    /// <summary>
    /// Стаус счёта
    /// </summary>
    public enum AccountStatus
    {
        /// <summary>
        /// Обычнай счёт
        /// </summary>
        USUAL = 0,

        /// <summary>
        /// Депозитный счёт
        /// </summary>
        DEPOSITORY = 1,

        /// <summary>
        /// Кредитный счёт
        /// </summary>
        CREDIT = 2
    }
}
