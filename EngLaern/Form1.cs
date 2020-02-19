using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngLaern
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }


        // ----BUTTON START in MENU----
        private void Start_Click(object sender, EventArgs e)
        {
            #region Przycisk Start - tworzenie nowego okna
            Form_Lesson lesson = new Form_Lesson();
            lesson.Show();
            lesson.Location = this.Location;
            this.Hide();
            #endregion
        }

        private void button_opcje_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region zamykanie - okno z zapytanie czy napewno
            Application.Exit();
            #endregion
        }
    }
}
