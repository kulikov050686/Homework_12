using Models;

namespace Services
{
    /// <summary>
    /// Хранилище счетов клиентов банка
    /// </summary>
    public class BankAccountRepository : RepositoryInMemory<BankAccount>
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public BankAccountRepository() : base(TestData.BankAccounts) { }

        /// <summary>
        /// Обновление данных счёта клиента банка
        /// </summary>
        /// <param name="source"> Новые данные счёта </param>
        /// <param name="destination"> Обновляемый счёт </param>
        protected override void Update(BankAccount source, BankAccount destination)
        {
            destination.Id = source.Id;
            destination.AccountStatus = source.AccountStatus;
            destination.Amount = source.Amount;
            destination.InterestRate = source.InterestRate;
        }
    }
}
