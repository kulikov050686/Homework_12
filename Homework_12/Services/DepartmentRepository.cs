using Models;
using System.Linq;

namespace Services
{
    /// <summary>
    /// Хранилище департаментов банка
    /// </summary>
    public class DepartmentRepository : RepositoryInMemory<Department>
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public DepartmentRepository() : base(TestData.Departments) { }

        /// <summary>
        /// Поиск департамента по имени
        /// </summary>
        /// <param name="nameDepartment"> Имя департамента </param>
        public Department Get(string nameDepartment)
        {
            return GetAll().FirstOrDefault(d => d.Name == nameDepartment);
        }
        
        /// <summary>
        /// Обновление данных департамента банка
        /// </summary>
        /// <param name="source"> Новые данные департамента </param>
        /// <param name="destination"> Обновляемый департамент </param>
        protected override void Update(Department source, Department destination)
        {
            destination.BankCustomers = source.BankCustomers;
            destination.Description = source.Description;
            destination.Id = source.Id;
            destination.Name = source.Name;
        }
    }
}
