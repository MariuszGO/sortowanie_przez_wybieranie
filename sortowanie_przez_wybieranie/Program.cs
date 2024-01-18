namespace sortowanie_przez_wybieranie
{

    public class sortowanie
    {
        public int [] wartosci = new int[10];

        public void pobierz()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podaj element " + i + " : ");
                this.wartosci[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void wyswietl()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(wartosci[i] + " ");
            }
        }

        public void sortuj()
        {
            int maksimum,tmp;
            for (int i = 0; i < 10; i++)
            {
               maksimum = wyszukaj_maksimum(i);
                tmp = wartosci[i];
                wartosci[i] = wartosci[maksimum];
                wartosci[maksimum]=tmp;
            }

        }

        private int wyszukaj_maksimum(int poczatek)
        {
            int maksymalny_index=poczatek;

            for(int i=poczatek; i< 10; i++)
            {
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
        }
    }
}