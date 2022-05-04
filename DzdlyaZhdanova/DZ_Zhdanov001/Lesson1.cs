using System;
using System.Collections.Generic;
using System.Text;

namespace DzdlyaZhdanova
{
    class Lesson1:ILess
    {
        public void Demo()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();

            list.AddFirst("I");
            list.AddNode("love");
            list.AddNode("dogs");

            Console.WriteLine(list.ToString());

            Console.WriteLine("Очистить задание по методу? Y/N");

            var clearLess = Console.ReadLine();

            if (clearLess == "Y")
            {
                list.Clear();
            }

            Console.ReadLine();
        }

        public string ID()
        {
            return "1";
        }

        public void Info()
        {
            Console.WriteLine("Разработка класса двусвязного списка");
        }
    }
}
