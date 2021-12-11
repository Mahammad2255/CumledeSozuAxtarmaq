using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string daxilEt;
            string axtarilanSoz;
            Console.WriteLine("Cumlenizi daxil edin");
            daxilEt = Console.ReadLine();
            string daxilETT = daxilEt.ToLower();
            Console.WriteLine("Axtarmaq istediyiniz sozu yazin: ");
            axtarilanSoz = Console.ReadLine();

            int counter = 0;

            string[] arr = daxilETT.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == axtarilanSoz)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
