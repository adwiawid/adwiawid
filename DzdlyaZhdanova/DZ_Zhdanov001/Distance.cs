using System;
using System.Collections.Generic;
using System.Text;

namespace DzdlyaZhdanova
{
    
    public struct PointStruct
    {
        public double X;
        public double Y;
    }

    
    public class PointClass
    {
        public double X;
        public double Y;
    }

    class Distance
    {    
        
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>

        private double PointDistance(PointClass pointOne, PointClass pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;

            return Math.Sqrt(x * x + y * y);
        }


        
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>
        
        private double PointDistanceEstimate(PointClass pointOne, PointClass pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;

            return (x * x + y * y);
        }

      
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>

        private double PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;

            return Math.Sqrt(x * x + y * y);
        }

       
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>

        private double PointDistanceEstimate(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;

            return (x * x + y * y);
        }

        static PointClass[] _pointClassArr;
        static PointStruct[] _pointStructArr;

        /// <param name="N"></param>
        private void Rand(int N)
        {
            Random rng = new Random();
            _pointClassArr = new PointClass[N];
            _pointStructArr = new PointStruct[N];

            Random rnd = new Random();

            for (int i = 0; i < N; i++)
            {
                PointClass ClassPoint = new PointClass();

                ClassPoint.X = rng.Next(-100, 100);
                ClassPoint.Y = rng.Next(-100, 100);

                _pointClassArr[i] = ClassPoint;

                PointStruct StructPoint = new PointStruct();

                StructPoint.X = rng.Next(-100, 100);
                StructPoint.Y = rng.Next(-100, 100);

                _pointStructArr[i] = StructPoint;
            }
        }

        /// <param name="N"></param>
        public Distance(int N)
        {
            Rand(N);
        }

       
        public void CalcDistanceForClassArr()
        {
            for (int i = 0; i < _pointClassArr.Length - 1; i++)
            {
                double a = PointDistance(_pointClassArr[i], _pointClassArr[i + 1]);
            }
        }

      
        public double[] DistanceForClassArr()
        {
            double[] arr = new double[_pointClassArr.Length - 1];

            for (int i = 0; i < _pointClassArr.Length - 1; i++)
            {
                arr[i] = PointDistance(_pointClassArr[i], _pointClassArr[i + 1]);
            }
            return arr;
        }

        public void CalcDistanceForStruct()
        {
            for (int i = 0; i < _pointStructArr.Length - 1; i++)
            {
                double a = PointDistance(_pointStructArr[i], _pointStructArr[i + 1]);
            }
        }

        
        public void CalcEstimateDistanceForClass()
        {
            for (int i = 0; i < _pointClassArr.Length - 1; i++)
            {
                double a = PointDistanceEstimate(_pointClassArr[i], _pointClassArr[i + 1]);
            }
        }

       
        public void CalcEstimateDistanceForStruct()
        {
            for (int i = 0; i < _pointStructArr.Length - 1; i++)
            {
                double a = PointDistanceEstimate(_pointStructArr[i], _pointStructArr[i + 1]);
            }
        }

        
        public double[] DistanceForStructArr()
        {
            double[] arr = new double[_pointStructArr.Length - 1];
            for (int i = 0; i < _pointStructArr.Length - 1; i++)
            {
                arr[i] = PointDistance(_pointStructArr[i], _pointStructArr[i + 1]);
            }
            return arr;
        }

        
        public double[] EstimateDistanceForClassArr()
        {
            double[] arr = new double[_pointClassArr.Length - 1];
            for (int i = 0; i < _pointClassArr.Length - 1; i++)
            {
                arr[i] = PointDistanceEstimate(_pointClassArr[i], _pointClassArr[i + 1]);
            }
            return arr;
        }

      
        public double[] EstimateDistanceForStructArr()
        {
            double[] arr = new double[_pointStructArr.Length - 1];
            for (int i = 0; i < _pointStructArr.Length - 1; i++)
            {
                arr[i] = PointDistanceEstimate(_pointStructArr[i], _pointStructArr[i + 1]);
            }
            return arr;
        }
    }
}
