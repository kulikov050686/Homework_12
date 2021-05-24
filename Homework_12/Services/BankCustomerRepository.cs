using Models;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BankCustomerRepository : RepositoryInMemory<BankCustomer>
    {
        public BankCustomerRepository() : base(TestData.BankCustomers) { }

        protected override void Update(BankCustomer source, BankCustomer destination)
        {
            destination.Id = source.Id;
            destination.Passport = source.Passport;
            destination.PhoneNumber = source.PhoneNumber;
            destination.Reliability = source.Reliability;
            destination.ClientStatus = source.ClientStatus;
            destination.Description = source.Description;
            destination.Email = source.Email;
        }
    }
}
