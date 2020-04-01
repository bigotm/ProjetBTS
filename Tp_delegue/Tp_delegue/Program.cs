using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_delegue
{
    class Program
    {
        delegate void PrototypeMaProcedure1(int i1, string s1);
        delegate void PrototypeMaProcedure2(int i1, int i2, int i3);
        delegate void PrototypeMaProcedure3(string s1, string s2, string s3);
        delegate void PrototypeMaProcedure4(double d1, string s1);
        delegate int PrototypeMaProcedure5();
        delegate string PrototypeMaProcedure6(int i);
        delegate double PrototypeMaProcedure7();
        delegate decimal PrototypeMaProcedure8(decimal d1, decimal d2);
        delegate int PrototypeMaProcedure9(string s1, string s2, string s3);
        delegate bool PrototypeMaProcedure10(int i, string s);
        delegate DateTime PrototypeMaProcedure11(double d1, string s);
        delegate double PrototypeMaProcedure12(bool b1, bool b2);
        delegate int PrototypeMaProcedure13(int l, DateTime dt);
        static void Main(string[] args)
        {
            PrototypeMaProcedure1 d1=null;
            d1 += p1;
            d1 += p4;
            d1 += p7;
            PrototypeMaProcedure2 d2 = null;
            d2 += p2;
            d2 += p5;
            d2 += p9;
            PrototypeMaProcedure3 d3 = null;
            d3 += p3;
            PrototypeMaProcedure11 d4 = null;
            d4 += f7;
            PrototypeMaProcedure13 d5 = null;
            d5 += f9;

            d1(5, "abc");
            d2(1, 2, 3);
            d3("abc", "def", "ghi");
            d4(1.2, "hello");
            d5(8, DateTime.Today);
            Console.ReadLine();
        }

        static void p1(int i1,string s1)
        {
            Console.WriteLine("je suis p1");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}",i1,s1);
        }

        static void p2(int i1, int i2,int i3)
        {
            Console.WriteLine("je suis p2");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}-{2}", i1, i2,i3);
        }

        static void p3(string s1, string s2, string s3)
        {
            Console.WriteLine("je suis p3");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}-{2}", s1, s2,s3);
        }

        static void p4(int i1, string s)
        {
            Console.WriteLine("je suis p4");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", i1, s);
        }

        static void p5(int i1, int i2, int i3)
        {
            Console.WriteLine("je suis p5");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}-{2}", i1, i2,i3);
        }

        static void p6(string s1, string s2,int i3)
        {
            Console.WriteLine("je suis p6");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}-{2}", s1, s2,i3);
        }

        static void p7(int i1,string s1)
        {
            Console.WriteLine("je suis p7");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", i1, s1);
        }

        static void p8(double d1, string s1)
        {
            Console.WriteLine("je suis p8");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", d1, s1);
        }

        static void p9(int j, int k, int l)
        {
            Console.WriteLine("je suis p9");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}-{2}", j, k,l);
        }

        static int f1()
        {
            Console.WriteLine("je suis f1");
            return 1;
        }

        static string f2(int i)
        {
            Console.WriteLine("je suis f2");
            return string.Format("La valeur de mes paramètres est {0}", i) ;
        }

        static double f3()
        {
            Console.WriteLine("je suis f3");
            return 1.2;
        }

        static decimal f4(decimal d1, decimal d2)
        {
            Console.WriteLine("je suis f4");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", d1, d2);
            return 1 / 2;
        }

        static int f5(string s1, string s2, string s3)
        {
            Console.WriteLine("je suis f5");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}-{2}", s1, s2,s3);
            return 1;
        }

        static bool f6(int i, string s)
        {
            Console.WriteLine("je suis f6");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", i, s);
            return true;
        }

        static DateTime f7(double d1, string s)
        {
            Console.WriteLine("je suis f7");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", d1, s);
            return DateTime.Today;
        }

        static double f8(bool b1, bool b2)
        {
            Console.WriteLine("je suis f8");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", b1, b2);
            return 1.2;
        }

        static int f9(int l, DateTime dt)
        {
            Console.WriteLine("je suis f8");
            Console.WriteLine("La valeur de mes paramètres est {0}-{1}", l, dt);
            return 1;
        }

    }
}
