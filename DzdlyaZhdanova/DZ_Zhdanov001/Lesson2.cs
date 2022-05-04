using System;
using System.Collections.Generic;
using System.Text;

namespace DzdlyaZhdanova
{
    class Lesson2 : ILess
    {
        public void Demo()
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.Write($"Стек содержит {stack.Count} элементов.");

            var item1 = stack.Pop();
            Console.WriteLine($"Верхний элемент {item1}.");
            var item2 = stack.Pop();
            Console.WriteLine($"Предпоследний элемент {item2}.");

            stack.Push(88);
            var item3 = stack.Peek();
            Console.WriteLine($"Новый верхний элемент {item3}.");
            var item4 = stack.Peek();
            Console.WriteLine($"Новый верхний элемент {item4}.");

            Console.ReadLine();
        }

        public string ID()
        {
            return "2";
        }

        public void Info()
        {
            Console.WriteLine("Реализация стэка");
        }
    }
}
