

namespace sortowanie_przez_wybieranie
{

    public class sortowanie
    {
        
        public int [] wartosci;
        public int ilosc = 0;

        public int n;

        public sortowanie()
        {
            Console.WriteLine("Podaj wielkosc tablicy: ");
            this.n = Convert.ToInt32(Console.ReadLine());
            wartosci = new int[n];
        }

        public void pobierz()
        {
            

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj element " + i + " : ");
                this.wartosci[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void wyswietl()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(wartosci[i] + " ");
            }
            Console.WriteLine("**********");
        }

/********************************************************
* nazwa funkcji: <sortuj>
* parametry wejściowe: <brak>
* wartość zwracana: <void - brak wartości zwracanej>
* autor: <PESEL>
* ****************************************************/



        public void sortuj()
        {
            int maksimum,tmp;
            for (int i = 0; i < n; i++)
            {
               maksimum = wyszukaj_maksimum(i);
                tmp = wartosci[i];
                wartosci[i] = wartosci[maksimum];
                wartosci[maksimum]=tmp;
            }

        }
/********************************************************
* nazwa funkcji: <wyszukaj_maksimum>
* parametry wejściowe: <poczatek - wartość całkowita określająca indeks od
*                       którego rozpoczynamy wyszukiwanie>
* wartość zwracana: <int - typ całkowity, indeks maksymalenej warości w tablicy>
* autor: <PESEL>
* ****************************************************/

        private int wyszukaj_maksimum(int poczatek)
        {
            int maksymalny_index=poczatek;

            for(int i=poczatek; i< n; i++)
            {
                ilosc++;
                if (wartosci[i] > wartosci[maksymalny_index])
                {
                    maksymalny_index = i;
                }
            }
            return maksymalny_index;
        }

}
        internal class Program
    {
        static void Main(string[] args)
        {
            sortowanie obiekt_sortowanie = new sortowanie();

            obiekt_sortowanie.pobierz();
            obiekt_sortowanie.wyswietl();
            obiekt_sortowanie.sortuj();
            obiekt_sortowanie.wyswietl();
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(Convert.ToString(
                obiekt_sortowanie.ilosc));
        }
    }
}