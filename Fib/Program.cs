using System.Diagnostics;

namespace Fib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer");
            _ = int.TryParse(Console.ReadLine(), out int n);

            List<int> res = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                res.Add(Fib2(i));
            }
            foreach (int i in res)
                Console.Write(i + ", ");

        }


        private static int Fib1(int n)
        {
            if (n < 1)
                return -1;
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else return Fib1(n - 1) + Fib1(n - 2);

        }


        private static int Fib2(int n)
        {
            int[] temp = new int [n];
            int tem;
            if (n < 1)
            { return -1; }
          
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if(i ==1 || i == 2)
                    {
                        tem = 1;                   
                    }
                    else
                    {
                        tem = temp[i - 2] + temp[i - 3];                   
                    }
                    temp[i - 1] = tem;

                }
                return temp[n - 1];

            }


        }
    }
}
