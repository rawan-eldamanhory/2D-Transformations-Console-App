using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //shape points
            Console.WriteLine(">>Main Points:");

            double P1X = 150;
            double P1Y = 100;
            Console.WriteLine("Point1 = " + P1X + " , " + P1Y);

            double P2X = 250;
            double P2Y = 100;
            Console.WriteLine("Point2 = " + P2X + " , " + P2Y);

            double P3X = 200;
            double P3Y = 200;
            Console.WriteLine("Point3 = " + P3X + " , " + P3Y);
            Console.WriteLine("....................................");

            //translation point
            double dX = 100;
            double dY = 50;

            //translation
            Console.WriteLine(">>Points after translation:");

            double P1XT_New = P1X + dX;
            double P1YT_New = P1Y + dY;
            Console.WriteLine("Point1 = " + P1XT_New + " , " + P1YT_New);

            double P2XT_New = P2X + dX;
            double P2YT_New = P2Y + dY;
            Console.WriteLine("Point2 = " + P2XT_New + " , " + P2YT_New);

            double P3XT_New = P3X + dX;
            double P3YT_New = P3Y + dY;
            Console.WriteLine("Point3 = " + P3XT_New + " , " + P3YT_New);
            Console.WriteLine("....................................");

            //scaling point
            double SX = 3;
            double SY = 2;

            //scaling
            Console.WriteLine(">>Points after scaling:");

            double P1XS_New = P1X * SX;
            double P1YS_New = P1Y * SY;
            Console.WriteLine("Point1 = " + P1XS_New + " , " + P1YS_New);

            double P2XS_New = P2X * SX;
            double P2YS_New = P2Y * SY;
            Console.WriteLine("Point2 = " + P2XS_New + " , " + P2YS_New);

            double P3XS_New = P3X * SX;
            double P3YS_New = P3Y * SY;
            Console.WriteLine("Point3 = " + P3XS_New + " , " + P3YS_New);
            Console.WriteLine("....................................");

            //rotation angle
            double angle = 45;
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);

            //rotation with clockwise
            Console.WriteLine(">>Points after rotation with clockwise:");
            double P1XRWNew = P1X * cos - P1Y * sin;
            double P1YRWNew = P1X * sin + P1Y * cos;
            Console.WriteLine("Point1 = " + P1XRWNew + " , " + P1YRWNew);

            double P2XRWNew = P2X * cos - P2Y * sin;
            double P2YRWNew = P2X * sin + P2Y * cos;
            Console.WriteLine("Point2 = " + P2XRWNew + " , " + P2YRWNew);

            double P3XRWNew = P3X * cos - P3Y * sin;
            double P3YRWNew = P3X * sin + P3Y * cos;
            Console.WriteLine("Point3 = " + P3XRWNew + " , " + P3YRWNew);
            Console.WriteLine("....................................");

            //rotation anti clockwise
            Console.WriteLine(">>Points after rotation anti clockwise:");

            double P1XRA_New = P1X * cos + P1Y * sin;
            double P1YRA_New = -P1X * sin + P1Y * cos;
            Console.WriteLine("Point1 = " + P1XRA_New + " , " + P1YRA_New);

            double P2XRA_New = P2X * cos + P2Y * sin;
            double P2YRA_New = -P2X * sin + P2Y * cos;
            Console.WriteLine("Point2 = " + P2XRA_New + " , " + P2YRA_New);

            double P3XRA_New = P3X * cos + P3Y * sin;
            double P3YRA_New = -P3X * sin + P3Y * cos;
            Console.WriteLine("Point3 = " + P3XRA_New + " , " + P3YRA_New);
            Console.WriteLine("....................................");

            //reflection against x
            Console.WriteLine(">>Points after reflection against x:");

            double P1XRX_New = P1X;
            double P1YRX_New = -P1Y;
            Console.WriteLine("Point1 = " + P1XRX_New + " , " + P1YRX_New);

            double P2XRX_New = P2X;
            double P2YRX_New = -P2Y;
            Console.WriteLine("Point2 = " + P2XRX_New + " , " + P2YRX_New);

            double P3XRX_New = P3X;
            double P3YRX_New = -P3Y;
            Console.WriteLine("Point3 = " + P3XRX_New + " , " + P3YRX_New);
            Console.WriteLine("....................................");

            //reflection against y
            Console.WriteLine(">>Points after reflection against y:");

            double P1XRY_New = -P1X;
            double P1YRY_New = P1Y;
            Console.WriteLine("Point1 = " + P1XRY_New + " , " + P1YRY_New);

            double P2XRY_New = -P2X;
            double P2YRY_New = P2Y;
            Console.WriteLine("Point2 = " + P2XRY_New + " , " + P2YRY_New);

            double P3XRY_New = -P3X;
            double P3YRY_New = P3Y;
            Console.WriteLine("Point3 = " + P3XRY_New + " , " + P3YRY_New);
            Console.WriteLine("....................................");

            //shearing point
            double ShX = 3;
            double ShY = 2;

            //shearing
            Console.WriteLine(">>Points after shearing:");

            double P1XSh_New = P1X + P1Y * ShY;
            double P1YSh_New = P1X * ShX + P1Y;
            Console.WriteLine("Point1 = " + P1XSh_New + " , " + P1YSh_New);

            double P2XSh_New = P2X + P2Y * ShY;
            double P2YSh_New = P2X * ShX + P2Y;
            Console.WriteLine("Point2 = " + P2XSh_New + " , " + P2YSh_New);

            double P3XSh_New = P3X + P3Y * ShY;
            double P3YSh_New = P3X * ShX + P3Y;
            Console.WriteLine("Point3 = " + P3XSh_New + " , " + P3YSh_New);

            Console.ReadLine();
        }
    }
}
