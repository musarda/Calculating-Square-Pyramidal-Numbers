using System;

public class musarda
{
   static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                toplam = 0;
                for(int j=1;j<=i;j++)
                {
                    toplam += j * j;
                    Console.Write(j+"^2");
                    if (j != i)
                    {
                        Console.Write(" + ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }
                Console.Write(toplam);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
}
