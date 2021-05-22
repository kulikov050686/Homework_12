using Models;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public class DepartmentRepository : RepositoryInMemory<Department<BankCustomer>>
    {
        protected override void Update(Department<BankCustomer> source, Department<BankCustomer> destination)
        {
            destination.BankCustomers = source.BankCustomers;
            destination.Description = source.Description;
            destination.Id = source.Id;
            destination.Name = source.Name;
        }
    }
}
