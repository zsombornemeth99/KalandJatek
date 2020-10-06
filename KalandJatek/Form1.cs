using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalandJatek
{
    public partial class Game : Form
    {
        private int ability = 0;
        private int character = 0;
        private string name = "";
        private Random r = new Random();
        private List<Karakter> harcosLista = new List<Karakter>();
        private Karakter valasztottKarakter;
        private int randomKarakter;
        private int map = 0;

        public Game()
        {
            karakterListaFeltoltes();
            InitializeComponent();
            Karakter1.Visible = false;
            BotKarakter.Visible = false;
            Név1.Visible = false;
            Bothp.Visible = false;
            CsataPanel.Visible = false;
            radio_Heal.Checked = true;
            setCharacterText();
            EleteroText.Text = "Életerő: 100";
            KepessegText.Text = "Képesség: Tudsz healelni(+5), emellett ha meghalnál, újra tudsz éledni.";
            map = r.Next(1, 5);
            this.BackgroundImage = Image.FromFile("assets/" + map.ToString() + ".png");
            WindowState = FormWindowState.Maximized;

            Csata_Kar1.Visible = true;
            Karakter1.Visible = true;
            Név1.Text = "";
            TxtBox_Name.Enabled = false;
            TxtBox_Name.Text = "Válassz karaktert!";
        }

        private void radio_Heal_Click(object sender, EventArgs e)
        {
            ability = 0;
            radio_Heal.Checked = true;
            radio_Defense.Checked = false;
            radio_Freeze.Checked = false;
            setCharacterText();
        }

        private void radio_Freeze_Click(object sender, EventArgs e)
        {
            ability = 1;
            radio_Heal.Checked = false;
            radio_Freeze.Checked = true;
            radio_Defense.Checked = false;
            setCharacterText();
        }

        private void radio_Defense_Click(object sender, EventArgs e)
        {
            ability = 2;
            radio_Heal.Checked = false;
            radio_Freeze.Checked = false;
            radio_Defense.Checked = true;
            setCharacterText();
        }

        private void pic_char1_Click(object sender, EventArgs e)
        {
            character = 1;
            TxtBox_Name.Enabled = true;
            TxtBox_Name.Text = "";
            pic_char1.BackColor = Color.Green;
            pic_char2.BackColor = Color.Transparent;
            pic_char3.BackColor = Color.Transparent;
            switch (character)
            {
                case 1:
                    Karakter1.Image = Image.FromFile("assets/Knight1L.png");
                    break;
                case 2:
                    Karakter1.Image = Image.FromFile("assets/Knight2L.png");
                    break;
                case 3:
                    Karakter1.Image = Image.FromFile("assets/Knight3L.png");
                    break;
            }
        }

        private void pic_char2_Click(object sender, EventArgs e)
        {
            character = 2;
            TxtBox_Name.Enabled = true;
            TxtBox_Name.Text = "";
            pic_char1.BackColor = Color.Transparent;
            pic_char2.BackColor = Color.Green;
            pic_char3.BackColor = Color.Transparent;
            switch (character)
            {
                case 1:
                    Karakter1.Image = Image.FromFile("assets/Knight1L.png");
                    break;
                case 2:
                    Karakter1.Image = Image.FromFile("assets/Knight2L.png");
                    break;
                case 3:
                    Karakter1.Image = Image.FromFile("assets/Knight3L.png");
                    break;
            }
        }

        private void pic_char3_Click(object sender, EventArgs e)
        {
            character = 3;
            TxtBox_Name.Text = "";
            TxtBox_Name.Enabled = true;
            pic_char1.BackColor = Color.Transparent;
            pic_char2.BackColor = Color.Transparent;
            pic_char3.BackColor = Color.Green;
            switch (character)
            {
                case 1:
                    Karakter1.Image = Image.FromFile("assets/Knight1L.png");
                    break;
                case 2:
                    Karakter1.Image = Image.FromFile("assets/Knight2L.png");
                    break;
                case 3:
                    Karakter1.Image = Image.FromFile("assets/Knight3L.png");
                    break;
            }
        }

        private void TxtBox_Name_TextChanged(object sender, EventArgs e)
        {
            name = TxtBox_Name.Text;

            if (TxtBox_Name.Text.Length <= 6 && TxtBox_Name.Text != "Válassz karaktert!")
            {
                Név1.Text = name;
                TxtBox_Name.BackColor = Color.White;
            } else if(TxtBox_Name.Text != "Válassz karaktert!")
            {
                TxtBox_Name.BackColor = Color.Red;
            }

            if (Név1.Text == "")
            {
                Név1.Visible = false;
            } else if(TxtBox_Name.Enabled == true)
            {
                Név1.Visible = true;
            }
        }

        private void Btn_Battle_Click(object sender, EventArgs e)
        {
            if (character == 0)
            {
                MessageBox.Show("Add meg melyik karakterrel játszol!");
            }
            else if (name == "")
            {
                MessageBox.Show("Add meg a neved!");
            }
            else if (name.Length > 6)
            {
                MessageBox.Show("A neved nem lehet több mint 6 karakter!");
            }
            else
            {
                // TOVÁBB A CSATÁHOZ
                NewMap.Visible = false;
                valasztottKarakter = new Karakter(name, ability);
                CsataPanel.Visible = true;
                MenuPanel.Visible = false;
                Karakter1.Visible = true;
                BotKarakter.Visible = true;
                Név1.Visible = true;
                Bothp.Visible = true;
                Név1.Text = name + ": " + valasztottKarakter.EletEro + "hp";
                randomKarakter = r.Next(harcosLista.Count);
                Bothp.Text = "Ellenfél: " + harcosLista[randomKarakter].EletEro.ToString() + "hp";
                switch (character)
                {
                    case 1:
                        Karakter1.Image = Image.FromFile("assets/Knight1L.png");
                        break;
                    case 2:
                        Karakter1.Image = Image.FromFile("assets/Knight2L.png");
                        break;
                    case 3:
                        Karakter1.Image = Image.FromFile("assets/Knight3L.png");
                        break;
                }
                switch (randomKarakter)
                {
                    case 0:
                        BotKarakter.Image = Image.FromFile("assets/Knight1R.png");
                        break;
                    case 1:
                        BotKarakter.Image = Image.FromFile("assets/Knight2R.png");
                        break;
                    case 2:
                        BotKarakter.Image = Image.FromFile("assets/Knight3R.png");
                        break;
                }
            }
        }

        private void karakterListaFeltoltes()
        {
            Karakter k1 = new Karakter("Bot1", r.Next(3));
            Karakter k2 = new Karakter("Bot2", r.Next(3));
            Karakter k3 = new Karakter("Bot3", r.Next(3));

            harcosLista.Add(k1);
            harcosLista.Add(k2);
            harcosLista.Add(k3);
        }

        private void HarcolGomb_Click(object sender, EventArgs e)
        {
            valasztottKarakter.Megkuzd(harcosLista[randomKarakter]);
            Név1.Text = name + ": " + valasztottKarakter.EletEro + "hp";
            Bothp.Text = "Ellenfél: " + harcosLista[randomKarakter].EletEro.ToString() + "hp";
            if(valasztottKarakter.KepessegElhasznalva == false)
            {
                KepessegGomb.BackColor = Color.White;
            }
            if (harcosLista[randomKarakter].EletEro == 0)
            {
                harcosLista[randomKarakter].csataVege(true);
            }
            else if (valasztottKarakter.EletEro == 0)
            {
                valasztottKarakter.csataVege(false);
            }
        }

        private void KepessegGomb_Click(object sender, EventArgs e)
        {
            KepessegGomb.BackColor = Color.Red;

            if (valasztottKarakter.KepessegElhasznalva == false)
            {
                // Használva a képesség
                switch (ability)
                {
                    case 0:
                        valasztottKarakter.Gyogyul();
                        break;
                    case 1:
                        valasztottKarakter.Fagyaszt();
                        break;
                    case 2:
                        valasztottKarakter.Kived();
                        break;
                }
            }
            Név1.Text = name + ": " + valasztottKarakter.EletEro + "hp";
            Bothp.Text = "Ellenfél: " + harcosLista[randomKarakter].EletEro.ToString() + "hp";
            if(harcosLista[randomKarakter].EletEro == 0)
            {
                harcosLista[randomKarakter].csataVege(true);
            } else if(valasztottKarakter.EletEro == 0)
            {
                valasztottKarakter.csataVege(false);
            }
        }

        private void setCharacterText()
        {
            switch (ability)
            {
                case 0:
                    SebzesText.Text = "Sebzés: 10";
                    KepessegText.Text = "Képesség: Tudsz healelni(+20), emellett ha meghalnál, egyszer a csata folyamán újraéledsz.";
                    KepessegGomb.Text = "GYÓGYÍTÁS";
                    break;
                case 1:
                    SebzesText.Text = "Sebzés: 8";
                    KepessegText.Text = "Képesség: Három támadást tudsz végrehajtani amíg az ellenfeled le van fagyasztva.";
                    KepessegGomb.Text = "FAGYASZTÁS";
                    break;
                case 2:
                    SebzesText.Text = "Sebzés: 11";
                    KepessegText.Text = "Képesség: Immunis leszel 2 ütésed idejéig az ellenfél ütéseire.";
                    KepessegGomb.Text = "KIVÉDÉS";
                    break;
            }
        }

        private void NewMap_Click(object sender, EventArgs e)
        {
            if(map == 4)
            {
                map = 1;
            } else
            {
                map++;
            }
            this.BackgroundImage = Image.FromFile("assets/" + map.ToString() + ".png");
        }

        private void KilepGomb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztos kilépsz?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
