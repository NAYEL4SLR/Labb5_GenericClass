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

            Check_2<double> check_2 = new Check_2<double>();
            Check_3<string> check_3 = new Check_3<string>();
            PrintResult(check_2.ToCheck(55.10, 55.10));    // double
            PrintResult(check_3.ToCheck("Hello", "Hi"));   // string

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
