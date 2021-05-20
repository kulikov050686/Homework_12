using System.Collections.Generic;
using System.Linq;

namespace Interfaces
{
    /// <summary>
    /// Интерфейс репозиторий
    /// </summary>
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Добавить сущность в репозиторий
        /// </summary>
        /// <param name="item"> Добавляемая сущность </param>
        void Add(T item);

        /// <summary>
        /// Удаление сущности из репозитория
        /// </summary>
        /// <param name="item"> Удяляемая сущность </param>
        bool Remove(T item);

        /// <summary>
        /// Обновление сущности в репозитории
        /// </summary>
        /// <param name="item"> Обновяемая сущность </param>
        void Update(int id, T item);

        /// <summary>
        /// Получить сущность по идентификатору
        /// </summary>
        /// <param name="id"> Идентификатор сущности </param>        
        T Get(int id) => GetAll().FirstOrDefault(item => item.Id == id);

        /// <summary>
        /// Получить все сущности
        /// </summary>        
        IEnumerable<T> GetAll();
    }
}
