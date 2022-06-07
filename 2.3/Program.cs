using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n (номер года) = ");
            int n = int.Parse(Console.ReadLine());
            int I = 0;
            int count = 0;
            int[] years = new int[n];
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] vdays = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] Thursdays = new int[55];
            for (int i = 0; i < years.Length; i++)
            {
                int year = i + 1;
                for (int j = 0; j < 12; j++)
                {
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        for (int k = 0; k < vdays[j]; k++)
                        {
                            if (I == 7) { I = 0; }
                            if (year == n && I == 3)
                            {
                                Thursdays[count] = k + 1;
                                count++;
                            }
                            I++;
                        }
                    }
                    else
                    {
                        for (int k = 0; k < days[j]; k++)
                        {
                            if (I == 7) { I = 0; }
                            if (year == n && I == 3)
                            {
                                Thursdays[count] = k + 1;
                                count++;
                            }
                            I++;
                        }
                    }
                }
            }
            for (int m = 0; m < Thursdays.Length; m++)
            {
                if (m < Thursdays.Length - 1 && Thursdays[m] > Thursdays[m + 1])
                {
                    Console.WriteLine(Thursdays[m]);
                }
            }
        }
    }
}
