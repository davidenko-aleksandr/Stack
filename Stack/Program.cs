using Stack.Array;
using Stack.NewStek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FixedStack<string> stack = new FixedStack<string>(8);
                stack.Push("Eleven");
                stack.Push("Twelve");
                stack.Push("Thirteen");
                stack.Push("Fourteen");

                var head = stack.Pop();
                Console.WriteLine(head);

                head = stack.Peek();
                Console.WriteLine(head);
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
            
            
            #region
            var mySteck = new MySteck<int>();
            mySteck.Push1(12);
            mySteck.Push1(23);
            mySteck.Push1(32);
            mySteck.Push1(57);
            mySteck.Push1(89);

            Console.WriteLine($"Cтек содержит {mySteck.count} элементов.");

            var myItem1 = mySteck.Pop1();
            Console.WriteLine($"Cтек содержит {mySteck.count} элементов.");
            var myItem2 = mySteck.Pop1();
            Console.WriteLine($"Крайний елемента стека - {myItem2}");
            #endregion



            #region

            /*   var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(23);
            stack.Push(324);
            stack.Push(12);
            stack.Push(43);
            Console.WriteLine($"Cтек содержит {stack.count} елементов");


            var item1 = stack.Pop();
            Console.WriteLine($"Верхний елемент {item1}");

            var item2 = stack.Peek();
            Console.WriteLine($"Новый верхний елемент {item2}");
            */
            #endregion
        }
    }
}
