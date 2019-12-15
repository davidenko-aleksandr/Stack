using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    /// <summary>
    /// Стек
    /// </summary>
    /// <typeparam name="T"> Тип данных в стеке </typeparam>
   public class Stack<T>
    {
        /// <summary>
        /// Коллекция хранимых данных(список)
        /// </summary>
        private List<T> _items = new List<T>();
      
        
        /// <summary>
        /// Кол-во елементов списка
        /// </summary>
        public int count => _items.Count;
      
        
        /// <summary>
        /// Добавляем данные в стек и проверяем на ноль
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
             _items.Add(item);
        }

        /// <summary>
        /// Получаем верхний ел-т стека с удалением
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            var item =  _items.LastOrDefault();
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст");
            }
            _items.RemoveAt(_items.Count - 1);

            return item;
        }

        /// <summary>
        /// Получаем верхний ел-т стека без удаления
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            var item = _items.LastOrDefault();
            if (item == null)
            {
                throw new NullReferenceException("Стек пуст");
            }
            return item;
        }
    }
}
