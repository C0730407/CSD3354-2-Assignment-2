//GAGANDEEP SINGH  C0730407
//RANDEEP KAUR  C0731777
//CSD3354 Section 1
//ASSIGNMENT 2
//March 7,2019
//LAB1
using System;

namespace ConsoleApp1
{
    public class Program
    {
        public delegate void MyDelegate();

        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate mydelegate = new MyDelegate(Method1);
            mydelegate();
        }
        static void Main(string[] args)
        {

        }
    }
}