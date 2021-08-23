using Interfaces;
using System;
using System.Collections.Generic;

namespace Services
{
    /// <summary>
    /// Базовый класс репозиторий 
    /// </summary>
    /// <typeparam name="T"> Тип хранимых сущностей </typeparam>
    abstract public class RepositoryInMemory<T> : IRepository<T> where T : IEntity
    {
        #region Закрытые поля

        private readonly List<T> _items = new List<T>();
        private int _lastId;

        #endregion

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        protected RepositoryInMemory()
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="items"> Список элементов </param>
        protected RepositoryInMemory(IEnumerable<T> items)
        {
            foreach (var item in items) Add(item);
        }
        
        /// <summary>
        /// Добавить в репозиторий
        /// </summary>
        /// <param name="item"> Добавляемый элемент </param>
        public void Add(T item)
        {
            if (item is null) 
                throw new ArgumentNullException(nameof(item));
            if (_items.Contains(item)) return;

            item.Id = ++_lastId;
            _items.Add(item);
        }

        /// <summary>
        /// Получить все элементы
        /// </summary>        
        public IEnumerable<T> GetAll() => _items;

        /// <summary>
        /// Удалить элемент из репозитория
        /// </summary>
        /// <param name="item"> Удаляемый элемент </param>        
        public bool Remove(T item) => _items.Remove(item);
        
        /// <summary>
        /// Обновление данных элемента
        /// </summary>
        /// <param name="id"> Идентификатор элемента </param>
        /// <param name="item"> Новые данные </param>
        public void Update(int id, T item)
        {
            if (item is null) 
                throw new ArgumentNullException(nameof(item));
            if (id <= 0) 
                throw new ArgumentOutOfRangeException(nameof(id), id, "Идентификатор неможет быть меньше 1");
            if (_items.Contains(item)) 
                return;

            var db_item = ((IRepository<T>)this).Get(id);

            if (db_item is null) 
                throw new InvalidOperationException("Редактируемый элемент не найден в репозитории");

            Update(item, db_item);
        }
        
        /// <summary>
        /// Обновление данных элемента
        /// </summary>
        /// <param name="source"> Новые данные </param>
        /// <param name="destination"> Обновляемый элемент </param>
        protected abstract void Update(T source, T destination);
    }
}
