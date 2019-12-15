using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.NewStek
{
    class MySteck<T>
    {
        private List<T> MyItem = new List<T>();

        public int count => MyItem.Count;

        public void Push1(T mItem)
        {
            if (mItem==null)
            {
                throw new ArgumentNullException(nameof(mItem));
            }

            MyItem.Add(mItem);
        }
        public T Pop1()
        {
            var mItem = MyItem.LastOrDefault();
            if (mItem==null)
            {
                throw new NullReferenceException("Стек пуст");
            }
            MyItem.RemoveAt(MyItem.Count - 1);
            return mItem;
        }
        public T Peek1()
        {
            var mItem = MyItem.LastOrDefault();
            if (mItem==null)
            {
                throw new NullReferenceException("Стек пуст");
            }
            return mItem;
        }

        

    }
}

