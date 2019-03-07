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
    public class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExcercises
    {
        public delegate int MyDelegate(int intValue);

        int  Method1(int intMethod1)
        {
            return intMethod1 * 4;
        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 20;
        }
            public void Method4(MyDelegate myDelegate)
        {
            for (int i = 1; i <= 5; i++)
                System.Console.Write(myDelegate(i) + " ");
        }
               public void Method3() 
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);
            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);
        }
    }
}
