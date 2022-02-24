using System;
using System.Collections;

namespace praktik2
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue makanan = new Queue();

            Stack minuman = new Stack();
            while (true)
            {
                try
                {
                    int pilihan;
                    Console.WriteLine("Mini Restaurant");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("1. Tampilkan daftar menu");
                    Console.WriteLine("2. Tampilkan daftar makanan");
                    Console.WriteLine("3. Tampilkan daftar minuman");
                    Console.WriteLine("4. Menambahkan daftar makanan baru");
                    Console.WriteLine("5. Menambahkan daftar minuman baru");
                    Console.WriteLine("6. Menghapus makanan");
                    Console.WriteLine("7. Menghapus minuman");
                    Console.WriteLine("8. Mencari makanan atau minuman");
                    Console.WriteLine("9. Quit");

                    Console.Write("Silahkan masukkan angka yang ingin di tampilkan : ");
                    pilihan = int.Parse(Console.ReadLine());



                    if (pilihan == 1)
                    {

                        Console.WriteLine("~~~~~~~~~~~~~~~");
                        Console.WriteLine("Daftar menu : ");

                        foreach (var value in makanan)
                        {
                            Console.WriteLine(value);
                        }
                        foreach (var value in minuman)
                        {
                            Console.WriteLine(value);
                        }

                    }
                    else if (pilihan == 2)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~");
                        Console.WriteLine("Daftar Makanan");

                        foreach (var value in makanan)
                        {
                            Console.WriteLine(value);
                        }
                    }

                    else if (pilihan == 3)
                    {
                        Console.WriteLine("~~~~~~~~~~~~~~~");
                        Console.WriteLine("Daftar Minuman");

                        foreach (var value in minuman)
                        {

                            Console.WriteLine(value);
                        }
                    }
                    else if (pilihan == 4)
                    {
                        Console.Write("Masukkan makanan : ");
                        string inputmakanan = Console.ReadLine();
                        makanan.Enqueue(inputmakanan);
                        Console.WriteLine("~~~~~~~~~~~~~~~");
                        Console.WriteLine("Daftar Makanan");
                        foreach (var value in makanan)
                        {
                            Console.WriteLine(value);
                        }

                    }
                    else if (pilihan == 5)
                    {
                        Console.Write("Masukkan munuman : ");
                        string inputminuman = Console.ReadLine();
                        minuman.Push(inputminuman);
                        Console.WriteLine("~~~~~~~~~~~~~~~");
                        Console.WriteLine("Daftar Minuman");
                        foreach (var value in minuman)
                        {
                            Console.WriteLine(value);
                        }
                    }
                    else if (pilihan == 6)
                    {
                        Console.Write($"Data yang terhapus = {makanan.Dequeue()} ");
                        Console.ReadLine();
                    }
                    else if (pilihan == 7)
                    {
                        Console.Write($"Data yang terhapus = {minuman.Pop()} ");
                        Console.ReadLine();
                    }
                    else if (pilihan == 8)
                    {
                        Console.WriteLine("Huruf depan wajib menggunakan kapital");
                        Console.Write("Masukkan Keyword : ");
                        string input = Console.ReadLine();
                        if (minuman.Contains(input) == true)
                        {
                            Console.WriteLine("Minuman tersedia");
                        }
                        else if (makanan.Contains(input) == true)
                        {
                            Console.WriteLine("Makanan tersedia");
                        }
                        else
                        {
                            Console.WriteLine("Data tidak tersedia");
                        }
                    }
                    else if (pilihan == 9)
                    {
                        Console.WriteLine("Terimakasih");
                        break;
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Format yang di masukkan harus angka!!");
                }
         
            }

        }

    }
}
