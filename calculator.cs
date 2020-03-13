class Calculator {
    static void Main (string[] args) {
        int a;
        int b;
        int pil;

        Console.WriteLine ("Nomor menu: ");
        Console.ReadLine (pil);
        Console.WriteLine ("Input nilai a: ");
        Console.ReadLine (a);
        Console.WriteLine ("Input nilai b: ");
        Console.ReadLine (b);

        switch (i) {
            case 1:
                Console.WriteLine ("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan (a, b));
                break;
            case 2:
                Console.WriteLine ("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan (a, b));
                break;
            case 3:
                Console.WriteLine ("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian (a, b));
                break;
            case 4:
                Console.WriteLine ("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian (a, b));
                break;
            case 5:
                Console.WriteLine ("Maaf menu yg anda pilih tidak tersedia");
                break;
        }
         Console.WriteLine ("\nTekan sembarang key untuk keluar");
                Console.ReadKey ();
    }

    static int Penambahan (int a, int b) {
        return a + b;
    }

    static int Pengurangan (int a, int b) {
        return a - b;
    }

    static int Perkalian (int a, int b) {
        return a * b;
    }

    static int Pembagian (int a, int b) {
        return a / b;
    }

}
