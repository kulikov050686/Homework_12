using Interfaces;
using System;
using System.Collections.Generic;

namespace Services
{
    /// <summary>
    /// Базовый класс репозиторий 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    abstract public class RepositoryInMemory<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new List<T>();
        private int _lastId;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        protected RepositoryInMemory()
        {
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="items"></param>
        protected RepositoryInMemory(IEnumerable<T> items) 
        {
            foreach (var item in items) Add(item);           
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            if (_items.Contains(item)) return;

            item.Id = ++_lastId;
            _items.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll() => _items;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item) => _items.Remove(item);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="item"></param>
        public void Update(int id, T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), id, "Идентификатор неможет быть меньше 1");
            if (_items.Contains(item)) return;

            var db_item = ((IRepository<T>)this).Get(id);

            if (db_item is null) throw new InvalidOperationException("Редактируемый элемент не найден в репозитории");

            Update(item, db_item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        protected abstract void Update(T source, T destination);        
    }
}
