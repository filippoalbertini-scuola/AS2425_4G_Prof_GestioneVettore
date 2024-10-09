namespace AS2425_4G_Prof_GestioneVettore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;4G;09/10/24;Gestione calcoli su un vettore");

            GestioneVoti voti = new GestioneVoti();
            int scelta;

            do
            {
                scelta = Menu();

                switch (scelta)
                {
                    case 1: // Caricamento valori (casuali)
                        voti.CaricaVotiRandom();
                        break;
                    case 2: // Calcolo media
                        double media = voti.Media();

                        Console.WriteLine($"La media è {media}");
                        break;
                    case 3: // Calcolo somma
                        break;
                    case 9: // Fine
                        break;
                }
            }
            while (scelta != 9);

        }

        /// <summary>
        /// Chiedi all'utente la scelta desiderata
        /// </summary>
        /// <returns></returns>
        static int Menu()
        {
            Console.WriteLine("Scelte :");
            Console.WriteLine("  1) Caricamento valori (casuali)");
            Console.WriteLine("  2) Calcolo media");
            Console.WriteLine("  3) Calcolo somma");
            Console.WriteLine("  9) Fine");

            int scelta = Convert.ToInt32(Console.ReadLine());
            return scelta;
        }
    }

    /// <summary>
    /// Gestione dei voti
    /// </summary>
    public class GestioneVoti
    {
        // attributo della classe
        private double[] voti;

        private int nVoti;

        // costruttore
        public GestioneVoti()
        {
            this.nVoti = 10;
            voti = new double[nVoti];
        }

        public GestioneVoti(int nVoti)
        {
            voti = new double[nVoti];
            this.nVoti = nVoti;
        }

        /// <summary>
        /// Carica voti "casuali" in voti[]
        /// </summary>
        public void CaricaVotiRandom()
        {
            Random r = new Random();

            for (int i = 0; i < nVoti; i++)
                voti[i] = r.Next(1, 10 + 1);

        }

        /// <summary>
        /// Calcola la media dei voti
        /// </summary>
        /// <returns></returns>
        public double Media()
        {
            double media = 0;

            for (int i = 0; i < nVoti; i++)
                media += voti[i];

            return media / (double)nVoti;
        }

        /// <summary>
        /// Calcola la somma dei voti
        /// </summary>
        /// <returns></returns>
        public double Somma()
        {
            return 0;
        }

    }

}
