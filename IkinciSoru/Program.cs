using System;

namespace IkinciSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program bir dizideki rakamların yatay histogram grafiğini çizer.\n\n");
            Console.Write("Eleman sayısını giriniz : ");
            int arrLength = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[arrLength];
            for(int i = 0; i<arrLength; i++)
            {
                Console.Write((i+1) + ". eleman : "); ;
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            int counter = 0;
            int maxCounter = 0;
            for(int i = 9; i >= 0; i--)
            {
                Console.Write(i + "| ");
                foreach(int value in arr)
                {
                    if(value == i)
                    {
                        counter++;
                        Console.Write("* ");
                        maxCounter = counter > maxCounter ? counter : maxCounter;
                    }
                }
                counter = 0;
                Console.WriteLine();
            }
            Console.WriteLine("---------------------");
            Console.Write(" ");
            for(int i = 0; i <= maxCounter; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
