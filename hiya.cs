using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace all {
    class Program {
        static void Main (string[] args) {
            int a, b, jum, kurg, kali, pil;
            decimal bagi;
            System.Console.WriteLine ("1. penjumlahan");
            System.Console.WriteLine ("2. pengurangan");
            System.Console.WriteLine ("3. perkalian");
            System.Console.WriteLine ("4. pembagian");
            System.Console.Write ("Masukan pilihan  : ");
            pil = int.Parse (System.Console.In.ReadLine ());
            System.Console.Write ("Masukan bilangan I  : ");
            a = int.Parse (System.Console.In.ReadLine ());
            System.Console.Write ("Masukan bilangan II : ");
            b = int.Parse (System.Console.In.ReadLine ());
            jum = a + b;
            kurg = a - b;
            kali = a * b;
            bagi = a / b;
            int i = Convert.ToInt16(pil);
            switch (i) {
                case 1:
                    System.Console.WriteLine ("Hasil penjumlahan " + jum);
                    break;
                case 2:
                    System.Console.WriteLine ("Hasil pengurangan " + kurg);
                    break;
                case 3:
                    System.Console.WriteLine ("Hasil perkalian " + kali);
                    break;
                case 4:
                    System.Console.WriteLine ("Hasil pembagian " + bagi);
                    break;
                case 5:
                    System.Console.WriteLine ("Menu tidak tersedia");
                    break;
            }

            System.Console.ReadLine ();

        }
    }
}