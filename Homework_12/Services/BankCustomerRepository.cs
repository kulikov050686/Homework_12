using Models;

namespace Services
{
    /// <summary>
    /// Хранилище клиентов банка
    /// </summary>
    public class BankCustomerRepository : RepositoryInMemory<BankCustomer>
    {
        /// <summary>
        /// Констрктор по умолчанию
        /// </summary>
        public BankCustomerRepository() : base(TestData.BankCustomers) { }

        /// <summary>
        /// Обновление данных клиента банка
        /// </summary>
        /// <param name="source"> Новые данные клиента </param>
        /// <param name="destination"> Обновляемый клиент </param>
        protected override void Update(BankCustomer source, BankCustomer destination)
        {
            destination.Id = source.Id;
            destination.Passport = source.Passport;
            destination.PhoneNumber = source.PhoneNumber;
            destination.Reliability = source.Reliability;
            destination.ClientStatus = source.ClientStatus;
            destination.Description = source.Description;
            destination.Email = source.Email;
            destination.BankAccounts = source.BankAccounts;
        }
    }
}
