using System;
using System.Linq;

namespace Kalkulatorsederhana
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("##  Program tebak angka  ##");
            Console.WriteLine("========================================");
            
            Console.WriteLine("Saya memikirkan sebuah angka antara 1 sampai 100");
            Console.WriteLine("Tebaklah angka berapa itu ?");

            Random rnd = new Random();
            int AngkaSaya = rnd.Next(1, 101);
            
            int[] AngkaYangSudahDitebak = Array.Empty<int>();

            while (true)
            {
                Console.Write("Masukkan angka : ");
                int AngkaTebakan = Convert.ToInt32(Console.ReadLine());

                if (AngkaTebakan == AngkaSaya)
                {
                    Console.WriteLine("Tebakanmu benar");
                    break;
                }
                else if (AngkaYangSudahDitebak.Contains(AngkaTebakan))
                {
                    Console.WriteLine("Kamu sudah menebak angka ini");
                }
                else if (AngkaTebakan < AngkaSaya)
                {
                    Console.WriteLine("Tebakanmu kurang besar");
                    
                    Array.Resize(ref AngkaYangSudahDitebak, AngkaYangSudahDitebak.Length + 1);
                    AngkaYangSudahDitebak[AngkaYangSudahDitebak.GetUpperBound(0)] = AngkaTebakan;
                } 
                else if (AngkaTebakan > AngkaSaya)
                {
                    Console.WriteLine("Tebakanmu kurang kecil");

                    Array.Resize(ref AngkaYangSudahDitebak, AngkaYangSudahDitebak.Length + 1);
                    AngkaYangSudahDitebak[AngkaYangSudahDitebak.GetUpperBound(0)] = AngkaTebakan;
                } 
                else {
                    Console.WriteLine("Tebakanmu salah");
                }
            }

            
        }
    }
}