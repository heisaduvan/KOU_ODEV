using System;

namespace DorduncuSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program verilen diziyi ters çevirir.");
            Console.Write("Eleman Sayısını Giriniz : ");
            int arrLength = Convert.ToInt16(Console.ReadLine());
            double[] arr = new double[arrLength];
            for(int i = 0; i < arrLength; i++)
            {
                Console.Write("Dizinin " + i + ". değeri : ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Dizinin ilk hali şu şekilde : ");
            for(int i = 0; i < arrLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            Console.Write("Dizinin ters çevrilmiş hali şu şekilde : ");
            ArrayReverse(arr,arrLength);
            Console.WriteLine("\n");

        }
        static void ArrayReverse(double[] arr, int N)
        {
            if(N > 0)
            {
                Console.Write(arr[N - 1] + " ");

                ArrayReverse(arr, N - 1);
            }
        }
    }
}
