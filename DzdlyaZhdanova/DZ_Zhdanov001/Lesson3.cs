using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzdlyaZhdanova
{
    class Lesson3 : ILess
    {
        public void Demo()
        {
            Console.Write("Введите номер теста от 1 до 2: ");
            var inputTest = Console.ReadLine();

            switch (inputTest)
            {
                case "1":
                    testOne();
                    break;
                case "2":
                    testTwo();
                    break;
                default:
                    break;
            }
        }

        public string ID()
        {
            return "3";
        }

        public void Info()
        {
            Console.WriteLine("Логгирование");
        }

        public Logger _log { get; set; }

        private void testOne()
        {
            int a = 2;
            int b = 0;
            int c = a / b;
        }

        private void testTwo()
        {
            int[] arr = new int[3];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
        }
    }
}
