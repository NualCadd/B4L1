using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    internal class Program
    {    
        static void Main()
        {

            Console.WriteLine("BAI 1: GHEP HO TEN");

            Console.Write("Nhap ho: ");
            string ho = Console.ReadLine();

            Console.Write("Nhap ten lot: ");
            string tenLot = Console.ReadLine();

            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();

            Console.WriteLine("Ho ten day du: {0} {1} {2}", ho, tenLot, ten);

            Console.WriteLine();


            Console.WriteLine("BAI 2: TACH HO TEN");

            Console.Write("Nhap ho ten day du: ");
            string fullName = Console.ReadLine();

            string[] parts = fullName.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            if (parts.Length >= 2)
            {
                string ho2 = parts[0];
                string ten2 = parts[parts.Length - 1];
                string tenLot2 = string.Join(" ", parts, 1, parts.Length - 2);

                Console.WriteLine("Ho: {0}", ho2);
                Console.WriteLine("Ten lot: {0}", tenLot2);
                Console.WriteLine("Ten: {0}", ten2);
            }
            else
            {
                Console.WriteLine("Ho ten khong hop le.");
            }

            Console.WriteLine();


            Console.WriteLine("BAI 3: CHUAN HOA HO TEN");

            Console.Write("Nhap ho ten khong theo chuan: ");
            string name = Console.ReadLine();

            string[] words = name.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries
            );

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            string result = string.Join(" ", words);

            Console.WriteLine("Ten theo dung chuan la: " + result);

            Console.ReadKey(true);
        }
    }
}

