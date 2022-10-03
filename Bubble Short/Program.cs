using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bubble_Short
{
    class Program
    {
        //Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        //deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //fungsi / method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array:");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 e1emen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-------------------------");
            
            //pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubblesortArray()
        {
            for (int i = 1; i < n; i++) //for n-1 passes
            {
                //pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])//jika elemen tidak dalam urutan yang benar
                    {
                        //tukar elemen 
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
            static void Main(string[] args)
        {
        }
    }
}
