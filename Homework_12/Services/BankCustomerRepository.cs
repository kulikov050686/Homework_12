using Models;
using System.Linq;

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
        /// Поиск клиента банка по идентификатору
        /// </summary>
        /// <param name="id"> Идентификатор </param>        
        public BankCustomer Get(int id)
        {
            return GetAll().FirstOrDefault(d => d.Id == id);
        }

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
            destination.DepositoryAccounts = source.DepositoryAccounts;
            destination.CreditAccounts = source.CreditAccounts;
        }
    }
}
