using System.Collections;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Powtorzenie_na_spr
{
    internal class Program
    {

        //1
        static int SumaP(int a, int b)
        {
            return a + b;
        }
        static int SumaP(int a, int b, int c)
        {
            return a + b + c;
        }
        static int SumaP(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        //2
        static double SumaD(double a = 1, double b = 1)
        {
            return a + b;
        }

        static double SumaD(double a = 1, double b = 1, double c = 1)
        {
            return a + b + c;
        }

        //3
        static string SumaS(string a = "", string b = "", string c = "", string d = "")
        {
            return a + b + c + d;
        }

        //4
        static void zamien(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //5
        static void ZamienAleLepsze(out int a)
        {
            a = 15;
        }

        //6
        static void superUltraMetoda(in int a) => Console.WriteLine(a);

        //7
        static int Iloczyn(params int[] tablica)
        {
            int wynik = 1;
            for(int i = 0; i < tablica.Length; i++)
            {
                wynik = wynik * tablica[i];
            }
            return wynik;
        }

        //8
        static T suma<T>(T a , T b) where T : INumber<T>
        {
            return a + b;
        }

        //9
        delegate double f1(double x, double y);

        static double suma(double x, double y) => x + y;
        static double roznica(double x, double y) => x - y;

        //10 - 11
        delegate double f(double x);
        static void Tablicowanie(f f)
        {
            for(double i = 0; i < 1; i += 0.1)
            {
                Console.WriteLine($" {i:F3} || {f(i):F3}");
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine(SumaD(12, 2,1));
            Console.WriteLine(SumaS(c: "miasto ", a: "limanowa ", b: "to "));
            Console.WriteLine(SumaS(b:"to ", a: "limanowa ", c: "miasto"));

            //9
            f1 f = suma;
            f(4, 2);
            f = roznica;
            f(4, 2);

            Console.WriteLine();

            //10 - 11
            f f2 = delegate (double a) { return a * a; };
            Tablicowanie(f2);
            Console.WriteLine();
            f2 = (double a) => a * a * a;
            Tablicowanie(f2);
            Console.WriteLine();

            //12
            List<int> lista = new List<int>() {1,2,3,4,5,1,2,3,4,5};

            lista.RemoveAt(2);
            lista.RemoveAt(5);
            lista.Insert(2, 67);
            lista.Insert(5, 67);
            foreach(int liczby in lista)
            {
                Console.Write($"{liczby}, ");
            }

            //13
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i = 0; i< lista.Count(); i++)
            {
                if (dic.ContainsKey(lista[i])) { dic[lista[i]]++; }
                else { dic.Add(lista[i], 1); }
            }

            //14
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < lista.Count(); i++)
            {
                set.Add(lista[i]);
            }

            foreach (int liczba in set)
            {
                Console.WriteLine(liczba);
            }


        }
    }
}
