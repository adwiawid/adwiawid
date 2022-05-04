
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace DzdlyaZhdanova
{
    class Lesson4 : ILess
    {
        public void Demo()
        {
            Console.Write("Введите количество точек: ");

            Distance distance = new Distance(int.Parse(Console.ReadLine()));

            Stopwatch stopWatch = new Stopwatch();

            Console.WriteLine("Вычисление дистанции для класса");
            stopWatch.Start();
            distance.CalcDistanceForClassArr();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Вычисление дистанции для структуры");
            stopWatch.Start();
            distance.CalcDistanceForStruct();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Вычисление оценки дистанции для класса");
            stopWatch.Start();
            distance.CalcEstimateDistanceForClass();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Вычисление оценки дистанции для структуры");
            stopWatch.Start();
            distance.CalcEstimateDistanceForStruct();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Массив значений дистанции для класса");
            stopWatch.Start();
            distance.DistanceForClassArr();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Массив значений дистанции для структуры");
            stopWatch.Start();
            distance.DistanceForStructArr();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Массив значений оценки дистанции для класса");
            stopWatch.Start();
            distance.EstimateDistanceForClassArr();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            stopWatch.Reset();
            Console.WriteLine();

            Console.WriteLine("Массив значений оценки дистанции для структуры");
            stopWatch.Start();
            distance.EstimateDistanceForStructArr();
            stopWatch.Stop();
            Console.WriteLine("Время выполнения: " + stopWatch.Elapsed.TotalSeconds + " сек");
            Console.WriteLine();
        }

        public string ID()
        {
            return "4";
        }

        public void Info()
        {
            Console.WriteLine("Вычисление дистанции между точками");
        }
    }
}
