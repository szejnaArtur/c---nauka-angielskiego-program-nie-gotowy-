namespace EngLaern
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.Text_englearn = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.button_opcje = new System.Windows.Forms.Button();
            this.button_wyjdz = new System.Windows.Forms.Button();
            this.button_strona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_englearn
            // 
            this.Text_englearn.AutoSize = true;
            this.Text_englearn.BackColor = System.Drawing.Color.Transparent;
            this.Text_englearn.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_englearn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Text_englearn.Location = new System.Drawing.Point(161, 100);
            this.Text_englearn.Name = "Text_englearn";
            this.Text_englearn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text_englearn.Size = new System.Drawing.Size(389, 78);
            this.Text_englearn.TabIndex = 0;
            this.Text_englearn.Text = "EngLearn";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(269, 194);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(163, 31);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // button_opcje
            // 
            this.button_opcje.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_opcje.Location = new System.Drawing.Point(269, 231);
            this.button_opcje.Name = "button_opcje";
            this.button_opcje.Size = new System.Drawing.Size(163, 31);
            this.button_opcje.TabIndex = 2;
            this.button_opcje.Text = "Opcje";
            this.button_opcje.UseVisualStyleBackColor = true;
            this.button_opcje.Click += new System.EventHandler(this.button_opcje_Click);
            // 
            // button_wyjdz
            // 
            this.button_wyjdz.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyjdz.Location = new System.Drawing.Point(269, 305);
            this.button_wyjdz.Name = "button_wyjdz";
            this.button_wyjdz.Size = new System.Drawing.Size(163, 31);
            this.button_wyjdz.TabIndex = 3;
            this.button_wyjdz.Text = "Wyjdź";
            this.button_wyjdz.UseVisualStyleBackColor = true;
            this.button_wyjdz.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_strona
            // 
            this.button_strona.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_strona.Location = new System.Drawing.Point(269, 268);
            this.button_strona.Name = "button_strona";
            this.button_strona.Size = new System.Drawing.Size(163, 31);
            this.button_strona.TabIndex = 4;
            this.button_strona.Text = "Strona";
            this.button_strona.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 429);
            this.Controls.Add(this.button_strona);
            this.Controls.Add(this.button_wyjdz);
            this.Controls.Add(this.button_opcje);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Text_englearn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 467);
            this.MinimumSize = new System.Drawing.Size(716, 467);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EngLearn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_englearn;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button button_opcje;
        private System.Windows.Forms.Button button_wyjdz;
        private System.Windows.Forms.Button button_strona;
    }
}

