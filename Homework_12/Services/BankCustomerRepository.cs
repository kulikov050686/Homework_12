using Models;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BankCustomerRepository : RepositoryInMemory<BankCustomerBaseClass>
    {
        protected override void Update(BankCustomerBaseClass source, BankCustomerBaseClass destination)
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
