using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            do
            {
                Console.Write("En az 3 harften oluşan bir kelime giriniz: ");
                kelime = Console.ReadLine();
                if (kelime.Length > 2)
                {
                    if (kelime != "q")
                    {
                        string palindrom = "";
                        for (int i = kelime.Length - 1; i >= 0; i--)
                        {
                            palindrom += kelime[i];
                        }
                        if (palindrom == kelime)
                        {
                            Console.WriteLine("Girdiğiniz kelime palindromdur.");
                        }
                        else if (palindrom != kelime)
                        {
                            Console.WriteLine("Girdiğiniz kelime palindrom değildir.");
                        }
                    }
                }
                else
                    Console.WriteLine("Girdiğiniz kelimenin en az 3 harften oluştuğuna emin olunuz.");
            } while (kelime != "q");

        }
    }
}
