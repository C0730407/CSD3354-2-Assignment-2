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
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }
        }
        public delegate int MyDelegate(out int i);

        public class DelegateExercises
        {
            int Method1(out int i)
            {
                i = 100;
                System.Console.WriteLine("Method1 " + i);
                return 0;
            }
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                MyDelegate myDelegate1 = null;
                MyDelegate myDelegate2 = myDelegate + myDelegate1;
                int intValue;
                myDelegate2(out intValue);
            }
        }

    }