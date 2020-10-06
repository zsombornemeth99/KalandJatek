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

        public Form1()
        {
            InitializeComponent();
            Karakter1.Visible = false;
            BotKarakter.Visible = false;
            Név1.Visible = false;
            Bothp.Visible = false;
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
            if (character == 0)
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
            }
        }
    }
}
