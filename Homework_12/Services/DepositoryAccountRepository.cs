using Models;
using System.Linq;

namespace Services
{
    /// <summary>
    /// Хранилище депозитарных счетов
    /// </summary>
    public class DepositoryAccountRepository : RepositoryInMemory<DepositoryAccount>
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DepositoryAccountRepository() : base(TestData.DepositoryAccount) { }

        /// <summary>
        /// Поиск депозитарного счёта по идентификатору
        /// </summary>
        /// <param name="id"> Идентификатор </param>        
        public DepositoryAccount Get(int id)
        {
            return GetAll().FirstOrDefault(d => d.Id == id);
        }

        /// <summary>
        /// Обновление данных 
        /// </summary>
        /// <param name="source"> Новые данные </param>
        /// <param name="destination"> Обновляемые данные </param>
        protected override void Update(DepositoryAccount source, DepositoryAccount destination)
        {
            destination.Id = source.Id;
            destination.AccountStatus = source.AccountStatus;
            destination.Amount = source.Amount;
            destination.InterestRate = source.InterestRate;
        }
    }
}
