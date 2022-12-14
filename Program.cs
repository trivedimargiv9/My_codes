/* First code
 * 
 * using simpson;
using System;
using System.Transactions;

namespace simpson
{
    public static class Globals
    {

          /// <summary>
        /// Console.WriteLine("Enter lower limit a : ");
        /// </summary>
        public const double a = 5.0;

        //Console.WriteLine("Enter lower limit b : ");
        public const double b = 10.0;

        // can take a and b here
        // can take n here
        //Console.WriteLine("Enter number of steps n : ");
        public const double n = 10.0;

        public const double deltax = (b - a) / n;


    }
                
    

    class program
    {
        // declare function
        // take a and b from user
        // take n from user
        // calculate deltax
        // formula


        static double func(double x)
        {
            return x * x;
        }

        static double ToCalculateSumOffuncs()
        {
            double sumofoddfunc = 0.0;
            double sumofevenfunc = 0.0;


            for (int i = 1; i <= 9; i = i + 2)
            {
                double xi = Globals.a + i * Globals.deltax;
                sumofoddfunc = 4 * (func(xi) + sumofoddfunc);
            }


            for (int j = 2; j < Globals.n; j = j + 2)
            {
                double xi = Globals.a + j * Globals.deltax;
                sumofevenfunc = 2 * (func(xi) + sumofevenfunc);
            }

            return sumofoddfunc + sumofevenfunc;

        }

        static void Integration()
        {
            double integratedvalue = (Globals.deltax / 3) * ((func(Globals.a) + func(Globals.n) + ToCalculateSumOffuncs()));

            Console.WriteLine("Integrated value is: " + integratedvalue);
           
        }

        static void Main()
        {
            //Console.WriteLine("Integrated value is:  ");
            Integration();
        }

    }
}

*/

/*
// C# program for simpson's 1/3 rule
using System;

public class GfG
{

    // Function to calculate f(x)
    static float func(float x)
    {
        return x * x;
    }

    // Function for approximate integral
    static float simpsons_(float ll, float ul,
                                        int n)
    {
        // Calculating the value of h
        float h = (ul - ll) / n;

        // Array for storing value of x
        // and f(x)
        float[] x = new float[10];
        float[] fx = new float[10];

        // Calculating values of x and f(x)
        for (int i = 0; i <= n; i++)
        {
            x[i] = ll + i * h;
            fx[i] = func(x[i]);
        }

        // Calculating result
        float res = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i == 0 || i == n)
                res += fx[i];
            else if (i % 2 != 0)
                res += 4 * fx[i];
            else
                res += 2 * fx[i];
        }

        res = res * (h / 3);
        return res;
    }

    // Driver Code
    public static void Main()
    {
        // Lower limit
        float lower_limit = 5;

        // Upper limit
        float upper_limit = 10;

        // Number of interval
        int n = 6;

        Console.WriteLine(simpsons_(lower_limit,
                                upper_limit, n));
    }
} */

// New code
using simpson;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;

namespace simpson
{
    /*public static class Globals
    {

        /// <summary>
        /// Console.WriteLine("Enter lower limit a : ");
        /// </summary>
        public const double a = 5.0;

        //Console.WriteLine("Enter lower limit b : ");
        public const double b = 10.0;

        // can take a and b here
        // can take n here
        //Console.WriteLine("Enter number of steps n : ");
        public const double n = 50.0;

        public const double deltax = (b - a) / n;


    }  */



    class program
    {
        // declare function
        // take a and b from user
        // take n from user
        // calculate deltax
        // formula


        static double func(double x)
        {
            return x * x;
        }



        static double ToCalculateSumOffuncs()
        {
            Console.WriteLine("Enter upper bound:  ");
            double ll = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter lower bound:  ");
            double ul = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of steps:  ");
            int n = Convert.ToInt32(Console.ReadLine());

            double deltax = (ul - ll) / n;


            double result = 0;
            double[] x = new double[10000];
            double[] fx = new double[10000];

            for(int i = 0;i <= n; i++)
            {
                x[i] = ll + i * deltax;
                fx[i] = func(x[i]);
            }


            for (int i = 0; i <= n; i++)
            {
                
                if(i == 0 || i == n)
                {
                    result = result + fx[i];
                }

                else if(i % 2 != 0)
                {
                    result += (4 * fx[i]);
                }

                else
                {
                    result += (2 * fx[i]);
                }
                
                
            }
            result = (deltax / 3) * result;


            return result;
        }


        static void Main()
        {
            //Console.WriteLine("Integrated value is:  ");
            Console.WriteLine("The integrated value is:  " + ToCalculateSumOffuncs());
        }

    }
}





