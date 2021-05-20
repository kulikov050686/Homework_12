using Models;

namespace Services
{
    /// <summary>
    /// 
    /// </summary>
    public class DepartmentRepository : RepositoryInMemory<Department<BankCustomerBaseClass>>
    {
        protected override void Update(Department<BankCustomerBaseClass> source, Department<BankCustomerBaseClass> destination)
        {
            destination.BankCustomers = source.BankCustomers;
            destination.Description = source.Description;
            destination.Id = source.Id;
            destination.Name = source.Name;
        }
    }
}
