using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3._2_HT
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        void Integer1()
        {
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(L / 100);
        }
        void Integer4()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A / B);
        }
        void Integer7()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum {0}", A / 10 + A % 10);
            Console.WriteLine("Mul {0}", (A / 10) * (A % 10));
        }
        void Integer10()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}", A % 10, (A / 10) % 10);
        }
        void Integer13()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}", A % 100, (A / 100));
        }
        void Integer16()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", A / 100, A % 10, (A / 10) % 10);
        }
        void Integer19()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A / 60);
        }
        void Integer22()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((A % 3600));
        }
        void Integer25()
        {
            int A = Convert.ToInt32(Console.ReadLine()) + 3;
            switch (A % 7)
            {
                case 0:
                    Console.WriteLine("воскресенье");
                    break;
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
            }
        }

        void Integer28()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int K = Convert.ToInt32(Console.ReadLine()) + N;
            switch (K % 7)
            {
                case 0:
                    Console.WriteLine("воскресенье");
                    break;
                case 1:
                    Console.WriteLine("понедельник");
                    break;
                case 2:
                    Console.WriteLine("вторник");
                    break;
                case 3:
                    Console.WriteLine("среда");
                    break;
                case 4:
                    Console.WriteLine("четверг");
                    break;
                case 5:
                    Console.WriteLine("пятница");
                    break;
                case 6:
                    Console.WriteLine("суббота");
                    break;
            }
        }

        void Boolean1()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N > 0);
        }
        void Boolean4()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A > 2 && B <= 3);
        }
        void Boolean7()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Max(A, C) >= B && B >= Math.Min(A, C));
        }
        void Boolean10()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((A % 2 == 0 && B % 2 != 0) || (A % 2 == 0 && B % 2 == 0));
        }
        void Boolean13()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A > 0 || B > 0 || C > 0);
        }
        void Boolean16()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A % 2 == 0 && A / 100 == 0 && A / 10 != 0);
        }
        void Boolean19()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A + B + C == A || A + B + C == B || A + B + C == C);
        }
        void Boolean22()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((A / 100 >= (A / 10) % 10 && A % 10 <= (A / 10) % 10) || (A / 100 <= (A / 10) % 10 && A % 10 >= (A / 10) % 10));
        }
        void Boolean25()//в заданиях этого типа, я считаю что точки на самих осях координат не принадлежат никакой чверти
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(X < 0 && Y > 0);// по идеи это же левая верхняя, да?
        }
        void Boolean28()//в заданиях этого типа, я считаю что точки на самих осях координат не принадлежат никакой чверти
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(X * Y > 0);
        }
        void Boolean31()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(A == B || B == C || A == C);
        }
        void Boolean34()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(X + Y % 2 == 1);
        }
        void Boolean37()
        {
            int X1 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Abs(X1 - X2) <= 1 && Math.Abs(Y1 - Y2) <= 1);
        }
        void Boolean40()
        {
            int X1 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((X1+1 == X2 && Y1+2==Y2) || (X1 + 2 == X2 && Y1 + 1 == Y2) || (X1 + 2 == X2 && Y1 -1 == Y2) || (X1 + 1 == X2 && Y1 - 2 == Y2) || (X1 - 1 == X2 && Y1 - 2 == Y2) || (X1 - 2 == X2 && Y1 - 1 == Y2) || (X1 - 2 == X2 && Y1 + 1 == Y2) || (X1 - 1 == X2 && Y1 + 2 == Y2));
        }
        void If3()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            if (A > 0) A++;
            else if (A < 0) A -= 2;
            else A = 10;
            Console.WriteLine(A);
        }
        void If6()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(A > B ? A : B);//ну или же Math.Max(A,B);
        }
        void If9()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Math.Max(A, B);
            A = Math.Min(A, B);
            B = C;
            Console.WriteLine("A = {0}, B = {1}", A, B);
        }
        void If12()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Min(Math.Min(A, B), C));
        }
        void If15()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(A + B + C - Math.Min(Math.Min(A, B), C));
        }
        void If18()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(A == B ? 3 : (A == C ? 2 : 1));
        }
        void If21()
        {
            double X = Convert.ToDouble(Console.ReadLine());
            double Y = Convert.ToDouble(Console.ReadLine());
            if (X == 0 && Y == 0) { Console.WriteLine(0); return; }
            if (X != 0 && Y != 0) { Console.WriteLine(3); return; }
            Console.WriteLine(X == 0 ? 2 : 1);
        }
        void If24()
        {
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(X > 0 ? 2 * Math.Sin(X) : 6 - X);
        }
        void If27()
        {
            double X = Convert.ToDouble(Console.ReadLine());
            if (X < 0) { Console.WriteLine(0); return; }
            if (Math.Floor(X) % 2 == 0) { Console.WriteLine(1); return; }
            if (Math.Floor(X) % 2 == 1) { Console.WriteLine(-1); return; }
        }
        void If30()
        {
            double X = Convert.ToDouble(Console.ReadLine());
            Console.Write(X % 2 == 0 ? "четное " : "нечетное ");
            if (X / 100 != 0) { Console.WriteLine("трехзначное число"); return; }
            if (X / 10 != 0) { Console.WriteLine("двузначное число"); return; }
            Console.WriteLine("однозначное число");
        }
    }
}
