using System;
using System.Threading;
using System.Windows.Forms;

namespace KalandJatek
{
    class Karakter
    {
        string nev;
        int eletEro;
        int sebzes;
        int maxEletero;
        int kepesseg;
        bool ujraelesztve;
        bool kepessegElhasznalva;
        int kepessegHasznalvaAKorben;
        bool kived = false;
        bool fagyaszt = false;
        int round = 0;


        public Karakter(string nev, int milyenKepesseg)
        {
            this.nev = nev;
            this.MaxEletero = 100;
            this.eletEro = maxEletero;
            this.kepessegElhasznalva = false;
            this.kepessegElhasznalva = false;


            if (milyenKepesseg == 0)
            {
                this.Sebzes = 10;
                kepesseg = milyenKepesseg;
            }
            else if (milyenKepesseg == 1)
            {
                this.Sebzes = 8;
                kepesseg = milyenKepesseg;
            }
            else
            {
                this.Sebzes = 11;
                kepesseg = milyenKepesseg;
            }
        }

        public string Nev { get => nev; set => nev = value; }
        public int EletEro { get => eletEro; set => eletEro = value; }
        public bool KepessegElhasznalva { get => kepessegElhasznalva; set => kepessegElhasznalva = value; }
        public int Sebzes { get => sebzes; set => sebzes = value; }
        public int MaxEletero { get => maxEletero; set => maxEletero = value; }

        
        public void Gyogyul()
        {
            if (kepessegElhasznalva == false)
            {
                if(EletEro+20 > 100)
                {
                    EletEro = MaxEletero;
                } else
                {
                    EletEro += 20;
                }
                kepessegElhasznalva = true;
            }
        }
        public void Fagyaszt()
        {
            if (kepessegElhasznalva == false)
            {
                kepessegElhasznalva = true;
                fagyaszt = true;
                kepessegHasznalvaAKorben = round;
            }
        }
        public void Kived()
        {
            if(kepessegElhasznalva == false)
            {
                kepessegElhasznalva = true;
                kived = true;
                kepessegHasznalvaAKorben = round;
            }
        }

        public void Megkuzd(Karakter masikHarcos)
        {
            round++;
            if(eletEro > 0)
            {
                if(fagyaszt == true)
                {
                    if(round - kepessegHasznalvaAKorben == 3)
                    {
                        KepessegElhasznalva = false;
                        fagyaszt = false;
                    }
                }
                else if (kived == true)
                {
                    if (round - kepessegHasznalvaAKorben == 2)
                    {
                        KepessegElhasznalva = false;
                        kived = false;
                    }
                }
                else
                {
                    eletEro -= masikHarcos.sebzes;
                    if(kepesseg == 0)
                    {
                        kepessegElhasznalva = false;
                    }
                }
            }
            if (masikHarcos.eletEro > 0)
            {
                masikHarcos.eletEro -= sebzes;
            }
            if(masikHarcos.eletEro <= 0 && masikHarcos.kepesseg == 0 && masikHarcos.ujraelesztve == false)
            {
                masikHarcos.eletEro = 100;
                MessageBox.Show("Az ellenfeled újraéledt a képessége miatt!");
                masikHarcos.ujraelesztve = true;
            }
            else if(masikHarcos.eletEro <= 0)
            {
                masikHarcos.eletEro = 0;
            }
            if(eletEro <= 0 && kepesseg == 0 && ujraelesztve == false)
            {
                eletEro = 100;
                MessageBox.Show("újraéledtél a képességed miatt!");
                ujraelesztve = true;
            }
            else if (eletEro <= 0)
            {
            }
        }
        public override string ToString()
        {
            return string.Format("{0} Életerő: {1} Sebzés: {2}", Nev, EletEro, Sebzes);
        }

        public void csataVege(bool jatekosGyozott)
        {
            if(jatekosGyozott == true)
            {
                if (MessageBox.Show("Nyertél\nEgy új játékot megpróbálsz?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                if (MessageBox.Show("Meghaltál\nMegpróbálod újra?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

    }
}
