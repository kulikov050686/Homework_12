﻿using Models;

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
