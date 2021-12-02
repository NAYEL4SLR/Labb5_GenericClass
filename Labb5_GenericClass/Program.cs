using System;

namespace Labb5_GenericClass
{
    class Check<T>
    {
        
        public bool ToCheck(T x, T y)
        {
            return x.Equals(y);
        }
    }
    class Check_2<T> : Check<T>
    { 

    }
    class Check_3<T> : Check<T>
    {
       
    }
    class Program
    {
        static void Main(string[] args)
        {

            Check_2<double> check_2a = new Check_2<double>();
            Check_2<string> check_2b = new Check_2<string>();

            Check_3<double> check_3a = new Check_3<double>();
            Check_3<string> check_3b = new Check_3<string>();


            PrintResult(check_2a.ToCheck(55.10, 55.10));    // double
            PrintResult(check_3a.ToCheck(30.10, 35.20));    // double
            PrintResult(check_2b.ToCheck("Hello", "Hi"));   // string
            PrintResult(check_3b.ToCheck("Hello", "Hello"));   // string

            Console.ReadLine();
        }
        static void PrintResult(bool compare)
        {
            if (compare)
            {
                Console.WriteLine("\n\tThe two variables are equal");
            }
            else
            {
                Console.WriteLine("\n\tThe two variables are NOT equal");

            }
        }
    }
}
