namespace KalandJatek
{
    class Karakter
    {
        string nev;
        int eletEro;
        int sebzes;



        public Karakter(string nev, int milyenKepesseg)
        {
            this.nev = nev;
            this.eletEro = 100;


            if (milyenKepesseg == 0)
                this.Sebzes = 10;
            else if (milyenKepesseg == 1)
                this.Sebzes = 8;
            else
                this.Sebzes = 11;
        }

        public string Nev { get => nev; set => nev = value; }
        public int EletEro { get => eletEro; set => eletEro = value; }
        public int Sebzes { get => sebzes; set => sebzes = value; }
    }
}
