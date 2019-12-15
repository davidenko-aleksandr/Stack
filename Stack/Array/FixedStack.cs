using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Array
{
   public class FixedStack<T>
    {
        private T[] items;
        private int count;
        const int N = 10;

        public FixedStack()
        {
            items = new T[N];
        }
        public FixedStack(int length)
        {
            items = new T[length];
        }
        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }
        public void Push (T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
            items[count++] = item;
        }
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T item = items[--count];
            items[count] = default(T);
            return item;
        }
        public T Peek()
        {
            return items[count - 1];
        }
    }
}
