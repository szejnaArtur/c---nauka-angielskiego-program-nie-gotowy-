using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Collections;

namespace EngLaern
{


    public partial class Form_AddLesson : Form
    {
        Form_Lesson lesson;
        public Form_AddLesson(Form_Lesson lesson)
        {
            InitializeComponent();
            this.lesson = lesson;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funkcje funkcja = new Funkcje();
            if (funkcja.sprawdzNazweLekcji(nazwaLekcji.Text))
            {
                info.Visible = true;
                info.Text = "Lekcja została stworzona!";
                info.ForeColor = Color.Green;

                DataClass.addLesson(nazwaLekcji.Text, "EngLearn.xml");

                XDocument loadFromDisk = XDocument.Load(@"EngLearn.xml");
                lesson.listaLekcji.Items.Clear();

                foreach (var item in loadFromDisk.Elements("Lekcje").Elements("Lekcja").Attributes("name"))
                {
                    lesson.listaLekcji.Items.Add(item.Value);
                }

                nazwaLekcji.Text = "";
                Close();

                Form_Editor editor = new Form_Editor();
                editor.ShowDialog();
            }
            else 
            {
                info.Visible = true;
                info.Text = "Nie poprawna nazwa!";
                info.ForeColor = Color.Red;
                nazwaLekcji.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
