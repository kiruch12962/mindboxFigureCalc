using System;

namespace FigureLibrary
{
    public class Figure
    {
        public static void CalcFigure()
        {
        out1:

            Console.Clear();

            Console.WriteLine("Enter circle radius or triangle sides");

            string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var value in arr)
            {
                double parseValue;
                bool success = double.TryParse(value, out parseValue);
                if (success == false || parseValue <= 0)
                {
                    Console.WriteLine("Incorrect data! Try again");
                    Console.ReadLine();
                    goto out1;
                }
            }
                if (arr.Length == 1 && Convert.ToDouble(arr[0])>0)
                {
                    Console.WriteLine("Circle");
                    double radius = Convert.ToDouble(arr[0]);
                    Circle.Area(radius);
                    Console.ReadLine();
                    goto out1;
                }
                if (arr.Length == 3 && Convert.ToDouble(arr[0])>0 && Convert.ToDouble(arr[1])>0 && Convert.ToDouble(arr[2])>0)
                {
                    
                    double aSide = Convert.ToDouble(arr[0]);
                    double bSide = Convert.ToDouble(arr[1]);
                    double cSide = Convert.ToDouble(arr[2]);

                    if (aSide < 0 || bSide < 0 || cSide < 0)
                    {
                        Console.WriteLine("Side can not be less than 0");
                        Console.ReadLine();
                        goto out1;
                    
                    }
                    if (aSide >= (bSide + cSide) || bSide >= (aSide + cSide) || cSide >= (aSide + bSide))
                    {
                        Console.WriteLine("Side greater than summary of two another sides");
                        Console.ReadLine();
                        goto out1;
                    }
                    else
                    {
                        Console.WriteLine("Triangle");
                        Triangle.Area(aSide, bSide, cSide);
                        Triangle.Rectangular(aSide, bSide, cSide);
                        Console.ReadLine();
                        goto out1;
                    }
                }
                if (arr.Length != 1 && arr.Length != 3)
                {
                    Console.WriteLine("Incorrect data! Try again");
                    Console.ReadLine();
                    goto out1;
                }
            
        }
    }
    public class Circle
    {
        public static double Area(double radius)
        {
            
            double CircleArea = Math.Round(Math.PI*Math.Pow(radius, 2), 4);
            Console.WriteLine($"Circle area = {CircleArea}");
            return CircleArea;
        }

    }
    public class Triangle
    {

        static public double Area(double aSide, double bSide, double cSide)
        {
            double Perimeter = aSide + bSide + cSide;
            double semiPer = Perimeter / 2;
            double TriangleArea = Math.Round(Math.Sqrt(semiPer * (semiPer - aSide) * (semiPer - bSide) * (semiPer - cSide)), 4);
            Console.WriteLine($"Triangle Area = {TriangleArea}");
            return TriangleArea;
        }
        static public bool Rectangular(double aSide, double bSide, double cSide)
        {
            if (aSide == Math.Sqrt(Math.Pow(bSide, 2) + Math.Pow(cSide, 2))
             || bSide == Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(cSide, 2))
             || cSide == Math.Sqrt(Math.Pow(aSide, 2) + Math.Pow(bSide, 2)))
            {
                Console.WriteLine("Triangle is rectangular");
                bool isRectangular = true;
                return isRectangular;
            }
            else
            {
                Console.WriteLine("Triangle is not rectangular");
                bool isRectangular = false;
                return isRectangular;
            }

        }
    }
}
