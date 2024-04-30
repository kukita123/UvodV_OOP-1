using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Да се състави програма, описваща клас за точка в равнината с полета координати на точката. 
 * Да се създадат нужните компоненти на класа - конструктори, свойства. 
 * Да се разработи метод за изчисляване разстоянието между две точки А и B по формулата: ...... 
 * Да се създаде масив от 10 (или n на брой) точки и да се намери най-малкото разстояние между кои да е две от тях.
 */
namespace Point_16._04._21
{    
    class Program
    {
        #region 9a
        //static Point GenerateCoords(Point p, Random random)
        //{            
        //    p.X = random.Next(-100, 100) * random.NextDouble();
        //    p.Y = random.Next(-100, 100) * random.NextDouble();

        //    return p;
        //}

        //static double distanse(Point A, Point B)
        //{
        //    return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        //}  
        
        //static double MinDistanse(Point[] points)
        //{
        //    double minDistance = distanse(points[0], points[1]);
        //    for (int i = 0; i < points.Length - 1; i++)
        //    {
        //        for (int j = i+1; j < points.Length; j++)
        //        {
        //            if (distanse(points[i],points[j]) < minDistance)
        //            {
        //                minDistance = distanse(points[i], points[j]);
        //            }
        //        }
        //    }
        //    return minDistance;
        //}

        //static void DisplayPointsArray(Point[] points)
        //{
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        Console.WriteLine("Point {0} coordinates:", i);
        //        Console.WriteLine("x = {0}", points[i].X);
        //        Console.WriteLine("y = {0}", points[i].Y);
        //        Console.WriteLine();
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {

            #region Main
            Point A = new Point();
            Console.WriteLine($"x = {A.X}, y = {A.Y}");

            Point B = new Point(0, 5);
            Console.WriteLine($"x = {B.X}, y = {B.Y}");

            //Apply two methods to calculate distance:

            Console.WriteLine($"Distance between points: {Distance(A, B)}");
            Console.WriteLine($"Distance between points: {A.DistanceInClass(B)}");


            Point[]points = new Point[10];                //points[i].X; points[i].Y
            Random random = new Random(); ////////!!!!!!!
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = GenerateRandomPoint(random);  ////////!!!!!!!!
            }

            foreach (var item in points)
            {
                Console.WriteLine($"x = {item.X}, y = {item.Y}");
            }

            Console.WriteLine("Min distance between points on tharray is: " + MinDistance(points));
            
            #endregion

            Console.ReadKey();
        }

        #region Methods
        static double Distance(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        static Point GenerateRandomPoint(Random random) 
        {
            Point point = new Point(random.Next(-100, 100) * random.NextDouble(), random.Next(-100, 100) * random.NextDouble());
            return point;
        }

        static double MinDistance(Point[] points)
        {
            double minDistance = Distance(points[0], points[1]);
            for (int i = 0; i < points.Length - 1; i++)
            {                
                for (int j = i + 1; j < points.Length; j++)
                {
                    double nextDistance = Distance(points[i], points[j]);
                    if (nextDistance < minDistance)
                        minDistance = nextDistance;
                }
            }
            return minDistance;
        }
        #endregion
    }
}
