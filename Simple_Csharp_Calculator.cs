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
                    //menginputkan angka pertama
                    Console.Write("Input angka pertama :");
                    int angka1 = Convert.ToInt32(Console.ReadLine());
                    //menginputkan angka kedua
                    Console.Write("Input angka kedua :");
                    int angka2 = Convert.ToInt32(Console.ReadLine());
                    /*menginputkan operasi sesuai dengan yang dipilih
                        1 = penambahan
                        2 = pengurangan
                        3 = perkalian
                        4 = pembagian
                    */
                    Console.Write("Inputkan operator yang dipilih (1/2/3/4) :");
                    string inputan = Console.ReadLine();

                    switch (inputan)
                    {
                        //operasi penambahan
                        case "1":
                            rumus = angka1 + angka2;
                            Console.WriteLine("Hasil penambahan adalah " + rumus);
                            break;
                        //operasi pengurangan
                        case "2":
                            rumus = angka1 - angka2;
                            Console.WriteLine("Hasil pengurangan adalah " + rumus);
                            break;
                        //operasi perkalian
                        case "3":
                            rumus = angka1 * angka2;
                            Console.WriteLine("Hasil perkalian adalah " + rumus);
                            break;
                        //operasi pembagian
                        case "4":
                            rumus = angka1 / angka2;
                            Console.WriteLine("Hasil pembagian adalah " + rumus);
                            break;
                        //operasi tidak ditemukan
                        default:
                            Console.WriteLine("Tidak ada pilihan operator");
                            break;
                    }
                
                Console.ReadLine();
                //inputan perulangan
                Console.Write("Lanjutkan perhitungan? (Ketik 'y' untuk melanjutkan");
                    loop = Console.ReadLine();
                }
                //nilai y untuk melanjutkan perulangan
                while (loop=="y");
        }
    }
}