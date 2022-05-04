using System;
using System.Collections.Generic;
using System.Text;

namespace DzdlyaZhdanova
{
    class Lesson5:ILess
    {
        public void Demo()
        {
            Console.Clear();

            var tree = new Tree<int>();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(6);
            tree.Add(2);
            tree.Add(4);
            tree.Add(9);

            foreach (var item in tree.Preorder())
            {
                tree.PrintTree(Console.WindowWidth / 4, 0, tree.Root);
            }

            Console.ReadLine();

            Console.WriteLine('\n');
            Console.WriteLine('\n');
        }

        public string ID()
        {
            return "5";
        }

        public void Info()
        {
            Console.WriteLine("Реализация бинарного дерева");
        }
    }
}
