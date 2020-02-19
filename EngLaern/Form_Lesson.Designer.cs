namespace EngLaern
{
    partial class Form_Lesson
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajLekcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujLekcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stoper = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.wyslij = new System.Windows.Forms.Button();
            this.lekcja_info = new System.Windows.Forms.Label();
            this.pausa = new System.Windows.Forms.Button();
            this.tlumaczenie = new System.Windows.Forms.TextBox();
            this.start_lekcja = new System.Windows.Forms.Button();
            this.slowo = new System.Windows.Forms.Label();
            this.trafienia_amount = new System.Windows.Forms.Label();
            this.bledy_amount = new System.Windows.Forms.Label();
            this.razem_amount = new System.Windows.Forms.Label();
            this.razem = new System.Windows.Forms.Label();
            this.bledy = new System.Windows.Forms.Label();
            this.trafienia = new System.Windows.Forms.Label();
            this.licznik = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listaLekcji = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.CheckBox();
            this.ENG_PL = new System.Windows.Forms.RadioButton();
            this.PL_ENG = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wznów = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajLekcjeToolStripMenuItem,
            this.edytujLekcjeToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.wyjdźToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.plikToolStripMenuItem.Text = "Lekcja";
            // 
            // dodajLekcjeToolStripMenuItem
            // 
            this.dodajLekcjeToolStripMenuItem.Name = "dodajLekcjeToolStripMenuItem";
            this.dodajLekcjeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.dodajLekcjeToolStripMenuItem.Text = "Dodaj Lekcje";
            this.dodajLekcjeToolStripMenuItem.Click += new System.EventHandler(this.dodajLekcjeToolStripMenuItem_Click);
            // 
            // edytujLekcjeToolStripMenuItem
            // 
            this.edytujLekcjeToolStripMenuItem.Name = "edytujLekcjeToolStripMenuItem";
            this.edytujLekcjeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.edytujLekcjeToolStripMenuItem.Text = "Edytuj Lekcje";
            this.edytujLekcjeToolStripMenuItem.Click += new System.EventHandler(this.edytujLekcjeToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.wznów);
            this.groupBox1.Controls.Add(this.stoper);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.wyslij);
            this.groupBox1.Controls.Add(this.lekcja_info);
            this.groupBox1.Controls.Add(this.pausa);
            this.groupBox1.Controls.Add(this.tlumaczenie);
            this.groupBox1.Controls.Add(this.start_lekcja);
            this.groupBox1.Controls.Add(this.slowo);
            this.groupBox1.Controls.Add(this.trafienia_amount);
            this.groupBox1.Controls.Add(this.bledy_amount);
            this.groupBox1.Controls.Add(this.razem_amount);
            this.groupBox1.Controls.Add(this.razem);
            this.groupBox1.Controls.Add(this.bledy);
            this.groupBox1.Controls.Add(this.trafienia);
            this.groupBox1.Controls.Add(this.licznik);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 403);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // stoper
            // 
            this.stoper.AutoSize = true;
            this.stoper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stoper.Location = new System.Drawing.Point(278, 26);
            this.stoper.Name = "stoper";
            this.stoper.Size = new System.Drawing.Size(96, 25);
            this.stoper.TabIndex = 16;
            this.stoper.Text = "00:00:00";
            this.stoper.Visible = false;
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stop.Location = new System.Drawing.Point(59, 63);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(268, 59);
            this.stop.TabIndex = 15;
            this.stop.Text = "Stop!";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Visible = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // wyslij
            // 
            this.wyslij.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyslij.Location = new System.Drawing.Point(28, 205);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(100, 26);
            this.wyslij.TabIndex = 14;
            this.wyslij.Text = "Sprawdź";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Visible = false;
            this.wyslij.Click += new System.EventHandler(this.wyslij_Click);
            // 
            // lekcja_info
            // 
            this.lekcja_info.AutoSize = true;
            this.lekcja_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lekcja_info.Location = new System.Drawing.Point(258, 210);
            this.lekcja_info.Name = "lekcja_info";
            this.lekcja_info.Size = new System.Drawing.Size(52, 16);
            this.lekcja_info.TabIndex = 13;
            this.lekcja_info.Text = "label12";
            this.lekcja_info.Visible = false;
            // 
            // pausa
            // 
            this.pausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pausa.Location = new System.Drawing.Point(112, 268);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(171, 26);
            this.pausa.TabIndex = 12;
            this.pausa.Text = "PAUSA";
            this.pausa.UseVisualStyleBackColor = true;
            this.pausa.Visible = false;
            this.pausa.Click += new System.EventHandler(this.pausa_Click);
            // 
            // tlumaczenie
            // 
            this.tlumaczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tlumaczenie.Location = new System.Drawing.Point(28, 172);
            this.tlumaczenie.Name = "tlumaczenie";
            this.tlumaczenie.Size = new System.Drawing.Size(334, 26);
            this.tlumaczenie.TabIndex = 11;
            this.tlumaczenie.Visible = false;
            // 
            // start_lekcja
            // 
            this.start_lekcja.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_lekcja.Location = new System.Drawing.Point(59, 63);
            this.start_lekcja.Name = "start_lekcja";
            this.start_lekcja.Size = new System.Drawing.Size(268, 59);
            this.start_lekcja.TabIndex = 0;
            this.start_lekcja.Text = "Sprawdz się!";
            this.start_lekcja.UseVisualStyleBackColor = true;
            this.start_lekcja.Click += new System.EventHandler(this.button1_Click);
            // 
            // slowo
            // 
            this.slowo.AutoSize = true;
            this.slowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.slowo.Location = new System.Drawing.Point(23, 147);
            this.slowo.Name = "slowo";
            this.slowo.Size = new System.Drawing.Size(68, 20);
            this.slowo.TabIndex = 10;
            this.slowo.Text = "SŁOWO";
            this.slowo.Visible = false;
            // 
            // trafienia_amount
            // 
            this.trafienia_amount.AutoSize = true;
            this.trafienia_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trafienia_amount.Location = new System.Drawing.Point(83, 344);
            this.trafienia_amount.Name = "trafienia_amount";
            this.trafienia_amount.Size = new System.Drawing.Size(14, 15);
            this.trafienia_amount.TabIndex = 9;
            this.trafienia_amount.Text = "0";
            this.trafienia_amount.Visible = false;
            // 
            // bledy_amount
            // 
            this.bledy_amount.AutoSize = true;
            this.bledy_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bledy_amount.Location = new System.Drawing.Point(190, 345);
            this.bledy_amount.Name = "bledy_amount";
            this.bledy_amount.Size = new System.Drawing.Size(14, 15);
            this.bledy_amount.TabIndex = 8;
            this.bledy_amount.Text = "0";
            this.bledy_amount.Visible = false;
            // 
            // razem_amount
            // 
            this.razem_amount.AutoSize = true;
            this.razem_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.razem_amount.Location = new System.Drawing.Point(296, 345);
            this.razem_amount.Name = "razem_amount";
            this.razem_amount.Size = new System.Drawing.Size(14, 15);
            this.razem_amount.TabIndex = 7;
            this.razem_amount.Text = "0";
            this.razem_amount.Visible = false;
            // 
            // razem
            // 
            this.razem.AutoSize = true;
            this.razem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.razem.Location = new System.Drawing.Point(279, 325);
            this.razem.Name = "razem";
            this.razem.Size = new System.Drawing.Size(47, 15);
            this.razem.TabIndex = 6;
            this.razem.Text = "Razem";
            this.razem.Visible = false;
            // 
            // bledy
            // 
            this.bledy.AutoSize = true;
            this.bledy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bledy.ForeColor = System.Drawing.Color.DarkRed;
            this.bledy.Location = new System.Drawing.Point(179, 325);
            this.bledy.Name = "bledy";
            this.bledy.Size = new System.Drawing.Size(37, 15);
            this.bledy.TabIndex = 5;
            this.bledy.Text = "Błędy";
            this.bledy.Visible = false;
            // 
            // trafienia
            // 
            this.trafienia.AutoSize = true;
            this.trafienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trafienia.ForeColor = System.Drawing.Color.DarkGreen;
            this.trafienia.Location = new System.Drawing.Point(63, 325);
            this.trafienia.Name = "trafienia";
            this.trafienia.Size = new System.Drawing.Size(55, 15);
            this.trafienia.TabIndex = 4;
            this.trafienia.Text = "Trafienia";
            this.trafienia.Visible = false;
            // 
            // licznik
            // 
            this.licznik.AutoSize = true;
            this.licznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.licznik.Location = new System.Drawing.Point(23, 25);
            this.licznik.Name = "licznik";
            this.licznik.Size = new System.Drawing.Size(42, 25);
            this.licznik.TabIndex = 1;
            this.licznik.Text = "0/0";
            this.licznik.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listaLekcji);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.czas);
            this.groupBox2.Controls.Add(this.ENG_PL);
            this.groupBox2.Controls.Add(this.PL_ENG);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(408, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 226);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcje Lekcji";
            // 
            // listaLekcji
            // 
            this.listaLekcji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaLekcji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listaLekcji.FormattingEnabled = true;
            this.listaLekcji.Location = new System.Drawing.Point(58, 23);
            this.listaLekcji.Name = "listaLekcji";
            this.listaLekcji.Size = new System.Drawing.Size(185, 23);
            this.listaLekcji.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(245, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(164, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(112, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rekord: ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(44, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Graj póki nie przegrasz!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czas.Location = new System.Drawing.Point(175, 74);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(53, 19);
            this.czas.TabIndex = 4;
            this.czas.Text = "Czas";
            this.czas.UseVisualStyleBackColor = true;
            // 
            // ENG_PL
            // 
            this.ENG_PL.AutoSize = true;
            this.ENG_PL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ENG_PL.Location = new System.Drawing.Point(29, 99);
            this.ENG_PL.Name = "ENG_PL";
            this.ENG_PL.Size = new System.Drawing.Size(78, 19);
            this.ENG_PL.TabIndex = 3;
            this.ENG_PL.TabStop = true;
            this.ENG_PL.Text = "EMG - PL";
            this.ENG_PL.UseVisualStyleBackColor = true;
            // 
            // PL_ENG
            // 
            this.PL_ENG.AutoSize = true;
            this.PL_ENG.Checked = true;
            this.PL_ENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PL_ENG.Location = new System.Drawing.Point(29, 73);
            this.PL_ENG.Name = "PL_ENG";
            this.PL_ENG.Size = new System.Drawing.Size(76, 19);
            this.PL_ENG.TabIndex = 2;
            this.PL_ENG.TabStop = true;
            this.PL_ENG.Text = "PL - ENG";
            this.PL_ENG.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lekcja: ";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(408, 255);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(27, 15);
            this.info.TabIndex = 3;
            this.info.Text = "info";
            this.info.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // wznów
            // 
            this.wznów.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wznów.Location = new System.Drawing.Point(112, 268);
            this.wznów.Name = "wznów";
            this.wznów.Size = new System.Drawing.Size(171, 26);
            this.wznów.TabIndex = 17;
            this.wznów.Text = "START";
            this.wznów.UseVisualStyleBackColor = true;
            this.wznów.Visible = false;
            this.wznów.Click += new System.EventHandler(this.wznów_Click);
            // 
            // Form_Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 429);
            this.Controls.Add(this.info);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(716, 467);
            this.MinimumSize = new System.Drawing.Size(716, 467);
            this.Name = "Form_Lesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lekcja";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label licznik;
        private System.Windows.Forms.Button start_lekcja;
        private System.Windows.Forms.RadioButton ENG_PL;
        private System.Windows.Forms.RadioButton PL_ENG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trafienia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox czas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tlumaczenie;
        private System.Windows.Forms.Label slowo;
        private System.Windows.Forms.Label trafienia_amount;
        private System.Windows.Forms.Label bledy_amount;
        private System.Windows.Forms.Label razem_amount;
        private System.Windows.Forms.Label razem;
        private System.Windows.Forms.Label bledy;
        private System.Windows.Forms.ToolStripMenuItem dodajLekcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujLekcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label info;
        public System.Windows.Forms.ComboBox listaLekcji;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.Label lekcja_info;
        private System.Windows.Forms.Button pausa;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label stoper;
        private System.Windows.Forms.Button wznów;
    }
}