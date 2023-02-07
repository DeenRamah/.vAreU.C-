using System;

namespace myApp
{
    class Mum
    {
        //using the return values in a program instead of using the void
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static int MyMethod7(int n, int w)
        {
            return n + w;
        }

        static int MyMethod6(int t)
        {
            return t;
        }
        /// <summary>
        /// /////////////////
        /// </summary>
   /////also we can send argument  with the key: value syntax
   ///the order of the argument does not matter
   ///

        static void Mymm(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " +child3);
        }
        /// <summary>
        /// //
        /// </summary>
        /// Method overloading 
        /// multiple methods can have the same name with different parameters
      static int Psum(int x, int y)
        {
            return x + y;
        }
      static double Psum(double x, double y)
        {
            return x + y;
        }

        static void Main(string[]args)
        {

            int MyNum = Psum(3, 5);
            double MyNum1 = Psum(3.4, 5.7);

            Console.WriteLine("double" +MyNum1);
            Console.WriteLine("int" +MyNum);

            int z = MyMethod(5, 9);
            Console.WriteLine(z);

            Console.WriteLine(MyMethod6(4));
            Console.WriteLine(MyMethod7(4 ,2));
            ///key: value
            Mymm(child3: "Bashir", child1: "Idris", child2: "Jibril");
        }
    }
}
