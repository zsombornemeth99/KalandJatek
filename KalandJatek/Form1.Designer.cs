namespace KalandJatek
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.pic_char1 = new System.Windows.Forms.PictureBox();
            this.radio_Heal = new System.Windows.Forms.RadioButton();
            this.radio_Freeze = new System.Windows.Forms.RadioButton();
            this.radio_Defense = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.EleteroText = new System.Windows.Forms.Label();
            this.SebzesText = new System.Windows.Forms.Label();
            this.pic_char2 = new System.Windows.Forms.PictureBox();
            this.pic_char3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.KepessegText = new System.Windows.Forms.Label();
            this.Btn_Battle = new System.Windows.Forms.Button();
            this.TxtBox_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Név1 = new System.Windows.Forms.Label();
            this.Karakter1 = new System.Windows.Forms.PictureBox();
            this.Csata_Kar1 = new System.Windows.Forms.Panel();
            this.Csata_Kar2 = new System.Windows.Forms.Panel();
            this.BotKarakter = new System.Windows.Forms.PictureBox();
            this.Bothp = new System.Windows.Forms.Label();
            this.HarcolGomb = new System.Windows.Forms.Button();
            this.KepessegGomb = new System.Windows.Forms.Button();
            this.CsataPanel = new System.Windows.Forms.Panel();
            this.NewMap = new System.Windows.Forms.Button();
            this.KilepGomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_char1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_char2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_char3)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Karakter1)).BeginInit();
            this.Csata_Kar1.SuspendLayout();
            this.Csata_Kar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotKarakter)).BeginInit();
            this.CsataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_char1
            // 
            this.pic_char1.BackColor = System.Drawing.Color.Transparent;
            this.pic_char1.Image = ((System.Drawing.Image)(resources.GetObject("pic_char1.Image")));
            this.pic_char1.Location = new System.Drawing.Point(17, 57);
            this.pic_char1.Name = "pic_char1";
            this.pic_char1.Size = new System.Drawing.Size(50, 50);
            this.pic_char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_char1.TabIndex = 0;
            this.pic_char1.TabStop = false;
            this.pic_char1.Click += new System.EventHandler(this.pic_char1_Click);
            // 
            // radio_Heal
            // 
            this.radio_Heal.AutoSize = true;
            this.radio_Heal.BackColor = System.Drawing.SystemColors.Control;
            this.radio_Heal.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.radio_Heal.Location = new System.Drawing.Point(17, 136);
            this.radio_Heal.Name = "radio_Heal";
            this.radio_Heal.Size = new System.Drawing.Size(101, 24);
            this.radio_Heal.TabIndex = 1;
            this.radio_Heal.TabStop = true;
            this.radio_Heal.Text = "Gyógyítás";
            this.radio_Heal.UseVisualStyleBackColor = false;
            this.radio_Heal.Click += new System.EventHandler(this.radio_Heal_Click);
            // 
            // radio_Freeze
            // 
            this.radio_Freeze.AutoSize = true;
            this.radio_Freeze.BackColor = System.Drawing.SystemColors.Control;
            this.radio_Freeze.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.radio_Freeze.Location = new System.Drawing.Point(17, 163);
            this.radio_Freeze.Name = "radio_Freeze";
            this.radio_Freeze.Size = new System.Drawing.Size(108, 24);
            this.radio_Freeze.TabIndex = 2;
            this.radio_Freeze.TabStop = true;
            this.radio_Freeze.Text = "Fagyasztás";
            this.radio_Freeze.UseVisualStyleBackColor = false;
            this.radio_Freeze.Click += new System.EventHandler(this.radio_Freeze_Click);
            // 
            // radio_Defense
            // 
            this.radio_Defense.AutoSize = true;
            this.radio_Defense.BackColor = System.Drawing.SystemColors.Control;
            this.radio_Defense.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.radio_Defense.Location = new System.Drawing.Point(17, 190);
            this.radio_Defense.Name = "radio_Defense";
            this.radio_Defense.Size = new System.Drawing.Size(84, 24);
            this.radio_Defense.TabIndex = 3;
            this.radio_Defense.TabStop = true;
            this.radio_Defense.Text = "Kivédés";
            this.radio_Defense.UseVisualStyleBackColor = false;
            this.radio_Defense.Click += new System.EventHandler(this.radio_Defense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.label1.Location = new System.Drawing.Point(13, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név:";
            // 
            // EleteroText
            // 
            this.EleteroText.AutoSize = true;
            this.EleteroText.BackColor = System.Drawing.SystemColors.Control;
            this.EleteroText.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.EleteroText.Location = new System.Drawing.Point(13, 261);
            this.EleteroText.Name = "EleteroText";
            this.EleteroText.Size = new System.Drawing.Size(62, 20);
            this.EleteroText.TabIndex = 5;
            this.EleteroText.Text = "Életerő:";
            // 
            // SebzesText
            // 
            this.SebzesText.AutoSize = true;
            this.SebzesText.BackColor = System.Drawing.SystemColors.Control;
            this.SebzesText.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.SebzesText.Location = new System.Drawing.Point(13, 281);
            this.SebzesText.Name = "SebzesText";
            this.SebzesText.Size = new System.Drawing.Size(60, 20);
            this.SebzesText.TabIndex = 6;
            this.SebzesText.Text = "Sebzés:";
            // 
            // pic_char2
            // 
            this.pic_char2.BackColor = System.Drawing.Color.Transparent;
            this.pic_char2.Image = ((System.Drawing.Image)(resources.GetObject("pic_char2.Image")));
            this.pic_char2.Location = new System.Drawing.Point(73, 57);
            this.pic_char2.Name = "pic_char2";
            this.pic_char2.Size = new System.Drawing.Size(50, 50);
            this.pic_char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_char2.TabIndex = 7;
            this.pic_char2.TabStop = false;
            this.pic_char2.Click += new System.EventHandler(this.pic_char2_Click);
            // 
            // pic_char3
            // 
            this.pic_char3.BackColor = System.Drawing.Color.Transparent;
            this.pic_char3.Image = ((System.Drawing.Image)(resources.GetObject("pic_char3.Image")));
            this.pic_char3.Location = new System.Drawing.Point(129, 57);
            this.pic_char3.Name = "pic_char3";
            this.pic_char3.Size = new System.Drawing.Size(50, 50);
            this.pic_char3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_char3.TabIndex = 9;
            this.pic_char3.TabStop = false;
            this.pic_char3.Click += new System.EventHandler(this.pic_char3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Válassz karaktert:";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.KepessegText);
            this.MenuPanel.Controls.Add(this.Btn_Battle);
            this.MenuPanel.Controls.Add(this.pic_char1);
            this.MenuPanel.Controls.Add(this.pic_char2);
            this.MenuPanel.Controls.Add(this.TxtBox_Name);
            this.MenuPanel.Controls.Add(this.SebzesText);
            this.MenuPanel.Controls.Add(this.pic_char3);
            this.MenuPanel.Controls.Add(this.EleteroText);
            this.MenuPanel.Controls.Add(this.label4);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.radio_Heal);
            this.MenuPanel.Controls.Add(this.radio_Defense);
            this.MenuPanel.Controls.Add(this.radio_Freeze);
            this.MenuPanel.Location = new System.Drawing.Point(12, 73);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(200, 516);
            this.MenuPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.label2.Location = new System.Drawing.Point(14, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Képesség:";
            // 
            // KepessegText
            // 
            this.KepessegText.AutoSize = true;
            this.KepessegText.BackColor = System.Drawing.SystemColors.Control;
            this.KepessegText.Font = new System.Drawing.Font("Montserrat", 8.25F);
            this.KepessegText.Location = new System.Drawing.Point(13, 310);
            this.KepessegText.MaximumSize = new System.Drawing.Size(180, 0);
            this.KepessegText.Name = "KepessegText";
            this.KepessegText.Size = new System.Drawing.Size(79, 20);
            this.KepessegText.TabIndex = 13;
            this.KepessegText.Text = "Képesség:";
            // 
            // Btn_Battle
            // 
            this.Btn_Battle.Font = new System.Drawing.Font("Montserrat", 12F);
            this.Btn_Battle.Location = new System.Drawing.Point(42, 456);
            this.Btn_Battle.Name = "Btn_Battle";
            this.Btn_Battle.Size = new System.Drawing.Size(110, 45);
            this.Btn_Battle.TabIndex = 12;
            this.Btn_Battle.Text = "CSATA!!";
            this.Btn_Battle.UseVisualStyleBackColor = true;
            this.Btn_Battle.Click += new System.EventHandler(this.Btn_Battle_Click);
            // 
            // TxtBox_Name
            // 
            this.TxtBox_Name.Location = new System.Drawing.Point(58, 231);
            this.TxtBox_Name.Name = "TxtBox_Name";
            this.TxtBox_Name.Size = new System.Drawing.Size(130, 22);
            this.TxtBox_Name.TabIndex = 11;
            this.TxtBox_Name.TextChanged += new System.EventHandler(this.TxtBox_Name_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(841, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 99);
            this.panel2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(14, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Németh Zsombor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(14, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Veres Márton";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(14, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nyírő Marcell Csaba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(53, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Készítők:";
            // 
            // Név1
            // 
            this.Név1.BackColor = System.Drawing.SystemColors.Control;
            this.Név1.Font = new System.Drawing.Font("Montserrat", 15F);
            this.Név1.ForeColor = System.Drawing.Color.Black;
            this.Név1.Location = new System.Drawing.Point(0, 13);
            this.Név1.Name = "Név1";
            this.Név1.Size = new System.Drawing.Size(200, 35);
            this.Név1.TabIndex = 13;
            this.Név1.Text = "NÉV1";
            this.Név1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Karakter1
            // 
            this.Karakter1.Location = new System.Drawing.Point(6, 62);
            this.Karakter1.Name = "Karakter1";
            this.Karakter1.Size = new System.Drawing.Size(191, 260);
            this.Karakter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Karakter1.TabIndex = 16;
            this.Karakter1.TabStop = false;
            // 
            // Csata_Kar1
            // 
            this.Csata_Kar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Csata_Kar1.BackColor = System.Drawing.Color.Transparent;
            this.Csata_Kar1.Controls.Add(this.Karakter1);
            this.Csata_Kar1.Controls.Add(this.Név1);
            this.Csata_Kar1.Location = new System.Drawing.Point(382, 250);
            this.Csata_Kar1.Name = "Csata_Kar1";
            this.Csata_Kar1.Size = new System.Drawing.Size(200, 334);
            this.Csata_Kar1.TabIndex = 18;
            // 
            // Csata_Kar2
            // 
            this.Csata_Kar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Csata_Kar2.BackColor = System.Drawing.Color.Transparent;
            this.Csata_Kar2.Controls.Add(this.BotKarakter);
            this.Csata_Kar2.Controls.Add(this.Bothp);
            this.Csata_Kar2.Location = new System.Drawing.Point(621, 250);
            this.Csata_Kar2.Name = "Csata_Kar2";
            this.Csata_Kar2.Size = new System.Drawing.Size(200, 334);
            this.Csata_Kar2.TabIndex = 19;
            // 
            // BotKarakter
            // 
            this.BotKarakter.Location = new System.Drawing.Point(6, 62);
            this.BotKarakter.Name = "BotKarakter";
            this.BotKarakter.Size = new System.Drawing.Size(191, 260);
            this.BotKarakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotKarakter.TabIndex = 16;
            this.BotKarakter.TabStop = false;
            // 
            // Bothp
            // 
            this.Bothp.BackColor = System.Drawing.SystemColors.Control;
            this.Bothp.Font = new System.Drawing.Font("Montserrat", 15F);
            this.Bothp.ForeColor = System.Drawing.Color.Black;
            this.Bothp.Location = new System.Drawing.Point(0, 12);
            this.Bothp.Name = "Bothp";
            this.Bothp.Size = new System.Drawing.Size(200, 35);
            this.Bothp.TabIndex = 13;
            this.Bothp.Text = "BOTHP";
            this.Bothp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HarcolGomb
            // 
            this.HarcolGomb.BackColor = System.Drawing.Color.White;
            this.HarcolGomb.Font = new System.Drawing.Font("Montserrat", 12F);
            this.HarcolGomb.Location = new System.Drawing.Point(18, 19);
            this.HarcolGomb.Name = "HarcolGomb";
            this.HarcolGomb.Size = new System.Drawing.Size(161, 45);
            this.HarcolGomb.TabIndex = 13;
            this.HarcolGomb.Text = "HARCOL";
            this.HarcolGomb.UseVisualStyleBackColor = false;
            this.HarcolGomb.Click += new System.EventHandler(this.HarcolGomb_Click);
            // 
            // KepessegGomb
            // 
            this.KepessegGomb.BackColor = System.Drawing.Color.White;
            this.KepessegGomb.Font = new System.Drawing.Font("Montserrat", 12F);
            this.KepessegGomb.Location = new System.Drawing.Point(18, 73);
            this.KepessegGomb.Name = "KepessegGomb";
            this.KepessegGomb.Size = new System.Drawing.Size(161, 45);
            this.KepessegGomb.TabIndex = 20;
            this.KepessegGomb.Text = "KÉPESSÉG";
            this.KepessegGomb.UseVisualStyleBackColor = false;
            this.KepessegGomb.Click += new System.EventHandler(this.KepessegGomb_Click);
            // 
            // CsataPanel
            // 
            this.CsataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CsataPanel.Controls.Add(this.KepessegGomb);
            this.CsataPanel.Controls.Add(this.HarcolGomb);
            this.CsataPanel.Location = new System.Drawing.Point(12, 449);
            this.CsataPanel.Name = "CsataPanel";
            this.CsataPanel.Size = new System.Drawing.Size(200, 140);
            this.CsataPanel.TabIndex = 20;
            // 
            // NewMap
            // 
            this.NewMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewMap.BackColor = System.Drawing.Color.White;
            this.NewMap.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.NewMap.Location = new System.Drawing.Point(816, 12);
            this.NewMap.Name = "NewMap";
            this.NewMap.Size = new System.Drawing.Size(102, 36);
            this.NewMap.TabIndex = 21;
            this.NewMap.Text = "Új pálya";
            this.NewMap.UseVisualStyleBackColor = false;
            this.NewMap.Click += new System.EventHandler(this.NewMap_Click);
            // 
            // KilepGomb
            // 
            this.KilepGomb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KilepGomb.BackColor = System.Drawing.Color.White;
            this.KilepGomb.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.KilepGomb.Location = new System.Drawing.Point(924, 12);
            this.KilepGomb.Name = "KilepGomb";
            this.KilepGomb.Size = new System.Drawing.Size(102, 36);
            this.KilepGomb.TabIndex = 22;
            this.KilepGomb.Text = "Kilépés\r\n";
            this.KilepGomb.UseVisualStyleBackColor = false;
            this.KilepGomb.Click += new System.EventHandler(this.KilepGomb_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 601);
            this.Controls.Add(this.KilepGomb);
            this.Controls.Add(this.NewMap);
            this.Controls.Add(this.CsataPanel);
            this.Controls.Add(this.Csata_Kar2);
            this.Controls.Add(this.Csata_Kar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalandjáték";
            ((System.ComponentModel.ISupportInitialize)(this.pic_char1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_char2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_char3)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Karakter1)).EndInit();
            this.Csata_Kar1.ResumeLayout(false);
            this.Csata_Kar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotKarakter)).EndInit();
            this.CsataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_char1;
        private System.Windows.Forms.RadioButton radio_Heal;
        private System.Windows.Forms.RadioButton radio_Freeze;
        private System.Windows.Forms.RadioButton radio_Defense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EleteroText;
        private System.Windows.Forms.Label SebzesText;
        private System.Windows.Forms.PictureBox pic_char2;
        private System.Windows.Forms.PictureBox pic_char3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button Btn_Battle;
        private System.Windows.Forms.TextBox TxtBox_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Név1;
        private System.Windows.Forms.PictureBox Karakter1;
        private System.Windows.Forms.Panel Csata_Kar1;
        private System.Windows.Forms.Panel Csata_Kar2;
        private System.Windows.Forms.PictureBox BotKarakter;
        private System.Windows.Forms.Label Bothp;
        private System.Windows.Forms.Button HarcolGomb;
        private System.Windows.Forms.Button KepessegGomb;
        private System.Windows.Forms.Panel CsataPanel;
        private System.Windows.Forms.Label KepessegText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewMap;
        private System.Windows.Forms.Button KilepGomb;
    }
}

