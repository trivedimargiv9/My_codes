using simpson;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;

namespace simpson
{
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
