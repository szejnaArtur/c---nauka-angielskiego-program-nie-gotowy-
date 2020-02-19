using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace EngLaern
{

    public partial class Form_Editor : Form
    {
        XDocument xml = XDocument.Load(@"EngLearn.xml");
        string[] slowoENG;
        string[] slowoPL;
        int[] liczba;
        int indeks = -1;

        public Form_Editor()
        {
            #region ładowanie listy lekcji
            InitializeComponent();
            foreach (var item in xml.Elements("Lekcje").Elements("Lekcja").Attributes("name"))
            {
                listaLekcji.Items.Add(item.Value);
            }
            #endregion
        }

        private void listaLekcji_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region zmiana elementu na liscie
            XDocument xml = XDocument.Load(@"EngLearn.xml");
            listaSlowek.Items.Clear();
            var query = from a in xml.Root.Elements("Lekcja")
                        where a.Attribute("name").Value == listaLekcji.Text
                        select a;

            int iloscElementow = 0;
            foreach (var slowo in query.Elements("word").Attributes("PLword"))
            {
                iloscElementow++;
            }
            slowoENG = new string[iloscElementow];
            slowoPL = new string[iloscElementow];
            int i = 0;
            foreach (var slowo in query.Elements("word").Attributes("ENGword"))
            {
                slowoENG[i] = slowo.Value;
                i++;
            }
            i = 0;
            foreach (var slowo in query.Elements("word").Attributes("PLword"))
            {
                slowoPL[i] = slowo.Value;
                i++;
            }

            for (i = 0; i < iloscElementow; i++)
            {
                ListViewItem listView = new ListViewItem(slowoPL[i]);
                listView.SubItems.Add(slowoENG[i]);
                listaSlowek.Items.Add(listView);
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Dodawanie nowego słowa - przycisk

            if (listaLekcji.Text == "")
            {
                info_edycja.Text = "Wybierz LEKCJE do której chcesz dodać nowe słowo!";
                info_edycja.ForeColor = Color.Red;
                info_edycja.Visible = true;
            }
            else
            {
                Funkcje sprawdzSlowa = new Funkcje();
                if (sprawdzSlowa.sprawdzPoprawnosc(slowoAngielskie.Text, slowoPolskie.Text))
                {
                    DataClass.AddNewWord(listaLekcji.Text, slowoPolskie.Text, slowoAngielskie.Text, "EngLearn.xml");

                    info_edycja.Text = "Słowo zostało dodane!";
                    info_edycja.Visible = true;
                    info_edycja.ForeColor = Color.Green;
                    slowoAngielskie.Text = "";
                    slowoPolskie.Text = "";
                    slowoPolskie.Focus();

                    listaSlowek.Items.Clear();
                    XDocument xml = XDocument.Load(@"EngLearn.xml");
                    var query = from a in xml.Root.Elements("Lekcja")
                                where a.Attribute("name").Value == listaLekcji.Text
                                select a;

                    int iloscElementow = 0;
                    foreach (var slowo in query.Elements("word").Attributes("PLword"))
                    {
                        iloscElementow++;
                    }
                    slowoENG = new string[iloscElementow];
                    slowoPL = new string[iloscElementow];
                    liczba = new int[iloscElementow];
                    int i = 0;
                    foreach (var slowo in query.Elements("word").Attributes("ENGword"))
                    {
                        slowoENG[i] = slowo.Value;
                        liczba[i] = i;
                        i++;
                    }
                    i = 0;
                    foreach (var slowo in query.Elements("word").Attributes("PLword"))
                    {
                        slowoPL[i] = slowo.Value;
                        i++;
                    }

                    for (i = 0; i < iloscElementow; i++)
                    {
                        ListViewItem listView = new ListViewItem(slowoPL[i]);
                        listView.SubItems.Add(slowoENG[i]);
                        listaSlowek.Items.Add(listView);
                    }
                }
                else
                {
                    info_edycja.Visible = true;
                    info_edycja.Text = "Źle wprowadzone słowo/a!";
                    info_edycja.ForeColor = Color.Red;
                }
            }

            #endregion
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            #region Przycisk - anuluj
            Close();
            #endregion
        }

        private void listaSlowek_Click(object sender, EventArgs e)
        {
            #region Wprowadzanie słów do pól edycji
            if (listaSlowek.SelectedItems.Count == 0) return;
            EdycjaSlowaPolskiego.Text = listaSlowek.SelectedItems[0].SubItems[0].Text;
            EdycjaSlowaAngielskiego.Text = listaSlowek.SelectedItems[0].SubItems[1].Text;
            PL.Text = listaSlowek.SelectedItems[0].SubItems[0].Text;
            ENG.Text = listaSlowek.SelectedItems[0].SubItems[1].Text;
            indeks = listaSlowek.SelectedItems[0].Index;
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Zamiana słówek - EDYCJA
            if (indeks >= 0)
            {
                Funkcje sprawdzSlowa = new Funkcje();
                if (sprawdzSlowa.sprawdzPoprawnosc(EdycjaSlowaAngielskiego.Text, EdycjaSlowaPolskiego.Text))
                {
                    DataClass.ChangeWord(listaLekcji.Text, "EngLearn.xml", indeks, EdycjaSlowaPolskiego.Text, EdycjaSlowaAngielskiego.Text);
                    info_edycja2.Visible = true;
                    info_edycja2.Text = "Słowo zostało poprawnie zmienione.";
                    info_edycja2.ForeColor = Color.Green;

                    listaSlowek.Items.Clear();
                    XDocument xml = XDocument.Load(@"EngLearn.xml");
                    var query = from a in xml.Root.Elements("Lekcja")
                                where a.Attribute("name").Value == listaLekcji.Text
                                select a;

                    int iloscElementow = 0;
                    foreach (var slowo in query.Elements("word").Attributes("PLword"))
                    {
                        iloscElementow++;
                    }
                    slowoENG = new string[iloscElementow];
                    slowoPL = new string[iloscElementow];
                    liczba = new int[iloscElementow];
                    int i = 0;
                    foreach (var slowo in query.Elements("word").Attributes("ENGword"))
                    {
                        slowoENG[i] = slowo.Value;
                        liczba[i] = i;
                        i++;
                    }
                    i = 0;
                    foreach (var slowo in query.Elements("word").Attributes("PLword"))
                    {
                        slowoPL[i] = slowo.Value;
                        i++;
                    }

                    for (i = 0; i < iloscElementow; i++)
                    {
                        ListViewItem listView = new ListViewItem(slowoPL[i]);
                        listView.SubItems.Add(slowoENG[i]);
                        listaSlowek.Items.Add(listView);
                    }
                    indeks = -1;
                    EdycjaSlowaPolskiego.Text = "";
                    EdycjaSlowaAngielskiego.Text = "";
                    PL.Text = "PL";
                    ENG.Text = "ENG";
                }
                else
                {
                    info_edycja2.Text = "Źle wprowadzone słowo!";
                    info_edycja2.Visible = true;
                    info_edycja2.ForeColor = Color.Red;
                }
            }
            else
            {
                info_edycja2.Text = "Wybierz słowo które chcesz zmienić.";
                info_edycja2.Visible = true;
                info_edycja2.ForeColor = Color.Red;
            }
            #endregion 
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            #region usuwanie słowek z xml i listy
            if (listaSlowek.SelectedItems.Count != 0)
            {
                DataClass.RemoveWord(listaLekcji.Text, "EngLearn.xml", listaSlowek.SelectedItems[0].Index);

                info_edycja2.Text = "Słowo zostało usunięte poprawnie.";
                info_edycja2.Visible = true;
                info_edycja2.ForeColor = Color.Green;

                XDocument xml = XDocument.Load(@"EngLearn.xml");
                listaSlowek.Items.Clear();
                var query = from a in xml.Root.Elements("Lekcja")
                            where a.Attribute("name").Value == listaLekcji.Text
                            select a;

                int iloscElementow = 0;
                foreach (var slowo in query.Elements("word").Attributes("PLword"))
                {
                    iloscElementow++;
                }
                slowoENG = new string[iloscElementow];
                slowoPL = new string[iloscElementow];
                liczba = new int[iloscElementow];
                int i = 0;
                foreach (var slowo in query.Elements("word").Attributes("ENGword"))
                {
                    slowoENG[i] = slowo.Value;
                    liczba[i] = i;
                    i++;
                }
                i = 0;
                foreach (var slowo in query.Elements("word").Attributes("PLword"))
                {
                    slowoPL[i] = slowo.Value;
                    i++;
                }

                for (i = 0; i < iloscElementow; i++)
                {
                    ListViewItem listView = new ListViewItem(slowoPL[i]);
                    listView.SubItems.Add(slowoENG[i]);
                    listaSlowek.Items.Add(listView);
                }
            }
            else
            {
                info_edycja2.Text = "Wybierz słowo które chcesz usunąć.";
                info_edycja2.Visible = true;
                info_edycja2.ForeColor = Color.Red;
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region przycisk usuń lekcje
            if (listaLekcji.Text == "")
            {
                info_edycja2.Text = "Wybierz LEKCJE którą chcesz usunąć!";
                info_edycja2.ForeColor = Color.Red;
                info_edycja2.Visible = true;
            }
            else
            {
                DataClass.RemoveLesson(listaLekcji.Text, "EngLearn.xml");
                info_edycja2.Text = "Lekcja została usunięta!";
                info_edycja2.ForeColor = Color.Green;
                info_edycja2.Visible = true;
                EdycjaSlowaAngielskiego.Text = "";
                EdycjaSlowaPolskiego.Text = "";
                PL.Text = "PL";
                ENG.Text = "ENG";

                XDocument xml = XDocument.Load(@"EngLearn.xml");
                listaLekcji.Items.Clear();
                foreach (var item in xml.Elements("Lekcje").Elements("Lekcja").Attributes("name"))
                {
                    listaLekcji.Items.Add(item.Value);
                }

                listaLekcji_SelectedIndexChanged(listaLekcji, null);
            }
            #endregion
        }


    }
}