//GAGANDEEP SINGH  C0730407
//RANDEEP KAUR  C0731777
//CSD3354 Section 1
//ASSIGNMENT 2
//March 7,2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _730407_731777
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises de = new DelegateExcercises();
            de.Method2();
        }
    }
    public class DelegateExcercises
    {
        public delegate void MyDelegate();

         void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }
}
