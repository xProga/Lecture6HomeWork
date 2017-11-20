using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lecture6HomeWork
{
    class Task1FuncMin
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double FPow(double a, double x)
        {
            return a * Math.Pow(x, 2);

        }

        public static double FSin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
    }

    public delegate double Func(double a, double x);
    public delegate double SimpleFunc(double x);

    class Task2FuncMin
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double FPow(double a, double x)
        {
            return a * Math.Pow(x, 2);

        }

        public static double FSin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        public static void SaveFunc(string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static double aaa(Func F)
        {
            double a = 0;

            F(1.2, 5.2);
            aaa(FPow);
            aaa(FSin);


            return a;
        }

    }
}
