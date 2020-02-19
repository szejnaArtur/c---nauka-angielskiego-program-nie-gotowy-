namespace EngLaern
{
    partial class Form_Editor
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaLekcji = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slowoPolskie = new System.Windows.Forms.TextBox();
            this.slowoAngielskie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.info_edycja = new System.Windows.Forms.Label();
            this.listaSlowek = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EdycjaSlowaAngielskiego = new System.Windows.Forms.TextBox();
            this.EdycjaSlowaPolskiego = new System.Windows.Forms.TextBox();
            this.info_edycja2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ENG = new System.Windows.Forms.TextBox();
            this.PL = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lekcja: ";
            // 
            // listaLekcji
            // 
            this.listaLekcji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaLekcji.FormattingEnabled = true;
            this.listaLekcji.Location = new System.Drawing.Point(53, 8);
            this.listaLekcji.Name = "listaLekcji";
            this.listaLekcji.Size = new System.Drawing.Size(236, 21);
            this.listaLekcji.TabIndex = 5;
            this.listaLekcji.SelectedIndexChanged += new System.EventHandler(this.listaLekcji_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(104, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dodaj Słowo:";
            // 
            // slowoPolskie
            // 
            this.slowoPolskie.Location = new System.Drawing.Point(99, 35);
            this.slowoPolskie.Name = "slowoPolskie";
            this.slowoPolskie.Size = new System.Drawing.Size(176, 20);
            this.slowoPolskie.TabIndex = 8;
            // 
            // slowoAngielskie
            // 
            this.slowoAngielskie.Location = new System.Drawing.Point(99, 60);
            this.slowoAngielskie.Name = "slowoAngielskie";
            this.slowoAngielskie.Size = new System.Drawing.Size(176, 20);
            this.slowoAngielskie.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Słowo Polskie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Słowa Angielskie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_anuluj
            // 
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.Location = new System.Drawing.Point(439, 322);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(131, 23);
            this.button_anuluj.TabIndex = 14;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Usuń Słowo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // info_edycja
            // 
            this.info_edycja.AutoSize = true;
            this.info_edycja.Location = new System.Drawing.Point(6, 114);
            this.info_edycja.Name = "info_edycja";
            this.info_edycja.Size = new System.Drawing.Size(58, 13);
            this.info_edycja.TabIndex = 16;
            this.info_edycja.Text = "info-edycja";
            this.info_edycja.Visible = false;
            // 
            // listaSlowek
            // 
            this.listaSlowek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listaSlowek.FullRowSelect = true;
            this.listaSlowek.GridLines = true;
            this.listaSlowek.Location = new System.Drawing.Point(6, 36);
            this.listaSlowek.Name = "listaSlowek";
            this.listaSlowek.Size = new System.Drawing.Size(283, 280);
            this.listaSlowek.TabIndex = 17;
            this.listaSlowek.UseCompatibleStateImageBehavior = false;
            this.listaSlowek.View = System.Windows.Forms.View.Details;
            this.listaSlowek.Click += new System.EventHandler(this.listaSlowek_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Słowo Polskie";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Słowo Angielskie";
            this.columnHeader3.Width = 140;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(101, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Edycja Słowa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Słowa Angielskie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Słowo Polskie";
            // 
            // EdycjaSlowaAngielskiego
            // 
            this.EdycjaSlowaAngielskiego.Location = new System.Drawing.Point(99, 87);
            this.EdycjaSlowaAngielskiego.Name = "EdycjaSlowaAngielskiego";
            this.EdycjaSlowaAngielskiego.Size = new System.Drawing.Size(176, 20);
            this.EdycjaSlowaAngielskiego.TabIndex = 20;
            // 
            // EdycjaSlowaPolskiego
            // 
            this.EdycjaSlowaPolskiego.Location = new System.Drawing.Point(99, 61);
            this.EdycjaSlowaPolskiego.Name = "EdycjaSlowaPolskiego";
            this.EdycjaSlowaPolskiego.Size = new System.Drawing.Size(176, 20);
            this.EdycjaSlowaPolskiego.TabIndex = 19;
            // 
            // info_edycja2
            // 
            this.info_edycja2.AutoSize = true;
            this.info_edycja2.Location = new System.Drawing.Point(10, 140);
            this.info_edycja2.Name = "info_edycja2";
            this.info_edycja2.Size = new System.Drawing.Size(58, 13);
            this.info_edycja2.TabIndex = 23;
            this.info_edycja2.Text = "info-edycja";
            this.info_edycja2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slowoPolskie);
            this.groupBox1.Controls.Add(this.slowoAngielskie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.info_edycja);
            this.groupBox1.Location = new System.Drawing.Point(297, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 135);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ENG);
            this.groupBox2.Controls.Add(this.PL);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.EdycjaSlowaPolskiego);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EdycjaSlowaAngielskiego);
            this.groupBox2.Controls.Add(this.info_edycja2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(297, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 167);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // ENG
            // 
            this.ENG.Enabled = false;
            this.ENG.Location = new System.Drawing.Point(144, 35);
            this.ENG.Name = "ENG";
            this.ENG.Size = new System.Drawing.Size(129, 20);
            this.ENG.TabIndex = 26;
            this.ENG.Text = "ENG";
            this.ENG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PL
            // 
            this.PL.Enabled = false;
            this.PL.Location = new System.Drawing.Point(8, 35);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(130, 20);
            this.PL.TabIndex = 25;
            this.PL.Text = "PL";
            this.PL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(144, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Zmień";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Usuń Lekcje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_anuluj;
            this.ClientSize = new System.Drawing.Size(585, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaSlowek);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.listaLekcji);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Name = "Form_Editor";
            this.Text = "Form_Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox listaLekcji;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox slowoPolskie;
        private System.Windows.Forms.TextBox slowoAngielskie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label info_edycja;
        private System.Windows.Forms.ListView listaSlowek;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EdycjaSlowaAngielskiego;
        private System.Windows.Forms.TextBox EdycjaSlowaPolskiego;
        private System.Windows.Forms.Label info_edycja2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox PL;
        private System.Windows.Forms.TextBox ENG;
        private System.Windows.Forms.Button button2;
    }
}