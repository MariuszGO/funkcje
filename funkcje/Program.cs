namespace funkcje
{
    internal class Program
    {
     

        static int suma(int liczba_a, int liczba_b, int liczba_c)
        {
            return liczba_a + liczba_b + liczba_c;
        }

        static int suma(int liczba_a = 22, int liczba_b = 33, int liczba_c = 344, int liczba_d = 33)
        {
            return liczba_a + liczba_b + liczba_c + liczba_d;
        }

        static void tablica(int[] tab1)
        {
            for(int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = 33+i*3;
            }
        }





        static void Main(string[] args)
        {
            int wynik,wynik1;
            int[] nasza_tablica = new int[100];
            Console.WriteLine(suma(1, 4));


            wynik = suma(12, 14, 33);
            Console.WriteLine(wynik);

            wynik1 = suma(0,22);
            Console.WriteLine(wynik1);

            tablica(nasza_tablica);

            for(int i = 0;i < nasza_tablica.Length; i++)
            {
                Console.Write(nasza_tablica[i] + " ");
            }


        }
    }
}