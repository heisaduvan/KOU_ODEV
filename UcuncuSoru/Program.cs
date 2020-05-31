using System;
using System.Text;

namespace UcuncuSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program girilen değerin aşağıdaki kurallara uygun olup olmadığını kontrol eder.");
            Console.WriteLine("- 8 karakterli olmalıdır.");
            Console.WriteLine("- Sadece rakam ve harflerden (İngiliz alfabesindeki) oluşmalıdır.");
            Console.WriteLine("- En az bir rakam ve harf bulunmalıdır.");
            Console.WriteLine("- Harfle başlamamalıdır.");
            Console.WriteLine("- Rakamla bitmemelidir.");
            Console.Write("\nYukarıdaki kurallara uyan bir değer yazın:");
            string value= Console.ReadLine();
            int returnValue = CheckString(value);
            if(returnValue == 1)
            {
                Console.WriteLine("Yazılan değer kuralları sağlıyor..");
            }
            else
            {
                Console.WriteLine("Yazılan değer kuralları sağlamıyor..");
            }
        }

        static int CheckString(string value)
        {
            int zeroAsciiCode = 48, nineAsciiCode = 57, A_AsciiCode = 65, a_AsciiCode = 97, Z_AsciiCode = 90, z_AsciiCode = 122;
            var asciiArray = Encoding.ASCII.GetBytes(value);
            bool checkAsciiControl = false;
            foreach(var asciiValue in asciiArray)
            {
                if((asciiValue >= zeroAsciiCode && asciiValue <= nineAsciiCode)
                    || (asciiValue >= A_AsciiCode && asciiValue <= Z_AsciiCode)
                    || (asciiValue >= a_AsciiCode && asciiValue <= z_AsciiCode))
                {
                    checkAsciiControl = true;
                }
                else
                {
                    checkAsciiControl = false;
                    break;
                }
            }
            if(checkAsciiControl)
            {
                char[] arr = value.ToCharArray();
                if(arr.Length == 8)
                {
                    if(!char.IsNumber(arr[arr.Length-1]))
                    {
                        bool isExistNumber = false, isExistLetter = false;
                        if(!char.IsLetter(arr[0]))
                        {
                            foreach(char ch in arr)
                            {
                                if(char.IsLetter(ch))
                                {
                                    isExistLetter = true;
                                }
                                if(char.IsNumber(ch))
                                {
                                    isExistNumber = true;
                                }
                            }
                        }
                        if(isExistNumber && isExistLetter)
                        {
                            return 1;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
