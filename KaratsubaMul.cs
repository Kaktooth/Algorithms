using System;

namespace ConsoleApp75
{
    class Koratsuba
    {
        static void Main(string[] args)
        {
            //Recursively compute a*c
            //Recursively compute b*d
            //Compute a+b and c+d and recursively compute (a+b)*(c+d)
            //Substract the results of the first two steps from the result of the third step to obtain a*d+b*c
            //Compute by adding up the results of steps1,2 and 4 after adding 10^n trailling zeroes to the answer in step 1 and 10^n/2 trailling zeroes to the answer in step 4
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            long result = 0;
            string n1 = Convert.ToString(num1);
            string n2 = Convert.ToString(num2);
            int a, b, c, d,p,q;
            long ac, bd, pq;
            long adbc;

            if (n1.Length==1|| n2.Length == 1)
            {
                result = num1 * num2;
            }
            else
            {
                int l = 0;
                
                if (n1.Length % 2 == 0)
                {
                    l = n1.Length / 2;
                    a = Convert.ToInt32(n1.Remove(l));
                    b = Convert.ToInt32(n1.Remove(0, l));
                }
                else
                {
                    l = (n1.Length+1) / 2;
                    a = Convert.ToInt32(n1.Remove(l));
                    b = Convert.ToInt32(n1.Remove(0, l));
                }

                if (n2.Length % 2 == 0)
                {
                    l = n2.Length / 2;
                    c = Convert.ToInt32(n2.Remove(l));
                    d = Convert.ToInt32(n2.Remove(0, l));
                }
                else
                {
                    l = (n1.Length + 1) / 2;
                    c = Convert.ToInt32(n2.Remove(l));
                    d = Convert.ToInt32(n2.Remove(0, l));
                }
                p = a + b;
                q = c + d;
                ac = a * c; bd = b * d; pq = p * q;
                adbc = pq - ac - bd;
                result = (long)Math.Pow(10, n1.Length) * ac + (long)Math.Pow(10, n1.Length / 2) * adbc + bd;


            }

            Console.WriteLine(result);
        }
    }
}
