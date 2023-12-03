using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeyiTersCevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ters Çevirmek İstediğiniz Kelimeyi Giriniz:");
            string kelime = Console.ReadLine();

            string terskelime = "";
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                terskelime += kelime[i];
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kelimenin Tersi:" + terskelime);

            Console.ReadLine();
        }
    }
}
