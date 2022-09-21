using System;

namespace Simple_Csharp_Calculator {
    class Operator
    {
        static void Main(String[] args)
        {
            string loop;
            do
            {
                Console.WriteLine("KALKULATOR SEDERHANA");
                Console.WriteLine("===============");
                Console.WriteLine("Inputkan 1 untuk melakukan operasi penambahan");
                Console.WriteLine("Inputkan 2 untuk melakukan operasi pengurangan");
                Console.WriteLine("Inputkan 3 untuk melakukan operasi perkalian");
                Console.WriteLine("Inputkan 4 untuk melakukan operasi pembagian");
                
                int rumus;
                Console.Write("Input angka pertama :");
                int angka1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input angka kedua :");
                int angka2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan operator :");
                string inputan = Console.ReadLine();

                switch (inputan)
                {
                    case "1":
                        rumus = angka1 + angka2;
                        Console.WriteLine("Hasil penambahan adalah " + rumus);
                        break;
                    case "2":
                        rumus = angka1 - angka2;
                        Console.WriteLine("Hasil pengurangan adalah " + rumus);
                        break;
                    case "3":
                        rumus = angka1 * angka2;
                        Console.WriteLine("Hasil perkalian adalah " + rumus);
                        break;
                    case "4":
                        rumus = angka1 / angka2;
                        Console.WriteLine("Hasil pembagian adalah " + rumus);
                        break;
                    default:
                        Console.WriteLine("Tidak ada pilihan operator");
                        break;
                }
            Console.ReadLine();
            Console.Write("Lanjutkan? (Ketik 'y' untuk melanjutkan");
            loop = Console.ReadLine();
            }

            while (loop=="y");
        }
    }
}