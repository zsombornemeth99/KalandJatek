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
    public partial class Form1 : Form
    {
        private int ability = 0;
        private int character;
        private string name = "";
        private Random r = new Random();
        private List<Karakter> harcosLista = new List<Karakter>();
        private Karakter valasztottKarakter;
        private int randomKarakter;

        public Form1()
        {
            karakterListaFeltoltes();
            InitializeComponent();
            Karakter1.Visible = false;
            BotKarakter.Visible = false;
            Név1.Visible = false;
            Bothp.Visible = false;
            CsataPanel.Visible = false;
        }

        private void radio_Heal_Click(object sender, EventArgs e)
        {
            ability = 0;
            radio_Heal.Checked = true;
            radio_Defense.Checked = false;
            radio_Freeze.Checked = false;
        }

        private void radio_Freeze_Click(object sender, EventArgs e)
        {
            ability = 1;
            radio_Heal.Checked = false;
            radio_Freeze.Checked = true;
            radio_Defense.Checked = false;
        }

        private void radio_Defense_Click(object sender, EventArgs e)
        {
            ability = 2;
            radio_Heal.Checked = false;
            radio_Freeze.Checked = false;
            radio_Defense.Checked = true;
        }

        private void pic_char1_Click(object sender, EventArgs e)
        {
            character = 0;
            pic_char1.BackColor = Color.Green;
            pic_char2.BackColor = Color.White;
            pic_char3.BackColor = Color.White;
        }

        private void pic_char2_Click(object sender, EventArgs e)
        {
            character = 1;
            pic_char1.BackColor = Color.White;
            pic_char2.BackColor = Color.Green;
            pic_char3.BackColor = Color.White;
        }

        private void pic_char3_Click(object sender, EventArgs e)
        {
            character = 2;
            pic_char1.BackColor = Color.White;
            pic_char2.BackColor = Color.White;
            pic_char3.BackColor = Color.Green;
        }

        private void TxtBox_Name_TextChanged(object sender, EventArgs e)
        {
            name = TxtBox_Name.Text;
        }

        private void Btn_Battle_Click(object sender, EventArgs e)
        {
            if (character == null)
            {
                MessageBox.Show("Add meg melyik karakterrel játszol!");
            }
            else if (name == "")
            {
                MessageBox.Show("Adj meg nevet a karakterednek!");
            }
            else
            {
                // TOVÁBB A CSATÁHOZ
                valasztottKarakter = new Karakter(name, ability);
                CsataPanel.Visible = true;
                MenuPanel.Visible = false;
                Karakter1.Visible = true;
                BotKarakter.Visible = true;
                Név1.Visible = true;
                Bothp.Visible = true;
                Név1.Text = name + " - " + valasztottKarakter.EletEro;
                randomKarakter = r.Next(harcosLista.Count);
                Bothp.Text = harcosLista[randomKarakter].EletEro.ToString();
                switch (character)
                {
                    case 0:
                        Karakter1.Image = Image.FromFile("assets/Knight1L.png");
                        break;
                    case 1:
                        Karakter1.Image = Image.FromFile("assets/Knight2L.png");
                        break;
                    case 2:
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
                valasztottKarakter.Megkuzd(harcosLista[randomKarakter]);
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
            Név1.Text = name + " - " + valasztottKarakter.EletEro;
            Bothp.Text = harcosLista[randomKarakter].EletEro.ToString();

        }

        private void GyogyitGomb_Click(object sender, EventArgs e)
        {
            valasztottKarakter.Gyogyul();
            Név1.Text = name + " - " + valasztottKarakter.EletEro;
            Bothp.Text = harcosLista[randomKarakter].EletEro.ToString();
        }
    }
}
