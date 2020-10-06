using System.Windows.Forms;

namespace KalandJatek
{
    class Karakter
    {
        string nev;
        int eletEro;
        int sebzes;
        int maxEletero;


        public Karakter(string nev, int milyenKepesseg)
        {
            this.nev = nev;
            this.MaxEletero = 100;
            this.eletEro = maxEletero;


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
        public int MaxEletero { get => maxEletero; set => maxEletero = value; }

        
        public void Gyogyul()
        {
            if (EletEro == 0)
                EletEro = MaxEletero;
            else
                EletEro += 5;
        }

        public void Megkuzd(Karakter masikHarcos)
        {
            if (this.eletEro == 0 || masikHarcos.eletEro == 0)
                MessageBox.Show("Hiba!");
            else
            {
                masikHarcos.eletEro -= this.Sebzes;
                if (masikHarcos.eletEro > 0)
                {
                    this.eletEro -= masikHarcos.Sebzes;
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0} Életerő: {1} Sebzés: {2}", Nev, EletEro, Sebzes);
        }

    }
}
