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
    public partial class Form_Lesson : Form
    {
        DateTime poczatek;
        TimeSpan ts;
        Random losowanie = new Random();
        string[] slowoENG;
        string[] slowoPL;
        bool[] flagi;
        int los, iloscElementow = 0, iloscLosowan = 0, l_trafien, l_bledow, l_razem, sekundy = 0, minuty = 0, godziny = 0;
        string liczba = "", text_sekundy = ":00", text_minuty = ":00", text_godziny = "00";
        public Form_Lesson()
        {
            #region tworzenie pliku EngLearn.xml i wczytywanie go
            InitializeComponent();
            if (!File.Exists("EngLearn.xml"))
            {
                XDocument documentXML = DataClass.createData();
                DataClass.SaveData("EngLearn.xml", documentXML);
            }

            XDocument loadFromDisk = XDocument.Load(@"EngLearn.xml");
            info.Text = "Plik EngLearn.xml został poprawnie załadowany";
            info.ForeColor = Color.Green;
            foreach (var item in loadFromDisk.Elements("Lekcje").Elements("Lekcja").Attributes("name"))
            {
                listaLekcji.Items.Add(item.Value);
            }
            #endregion
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            #region zamykanie lekcji - okno z zapytanie czy napewno
            base.OnClosing(e);

            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie programu...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = true;
                Application.Exit();
            }
            #endregion
        }

        private void dodajLekcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region przycisk dodaj lekcje w menu - tworzenie nowego okna
            Form_AddLesson AddLesson = new Form_AddLesson(this);
            AddLesson.ShowDialog();
            AddLesson.Location = this.Location;
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region przycisk dodaj lekcje przycisk - tworzenie nowego okna
            Form_AddLesson AddLesson = new Form_AddLesson(this);
            AddLesson.ShowDialog();
            AddLesson.Location = this.Location;
            #endregion
        }

        private void edytujLekcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Edytor lekcji przycisk menu
            Form_Editor editor = new Form_Editor();
            editor.ShowDialog();
            #endregion
        }

        private void wyjdźToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region zamykanie lekcji - okno z zapytanie czy napewno
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie programu...", MessageBoxButtons.YesNo) == DialogResult.Yes) Application.Exit();
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Przycisk - sprawdz się
            XDocument xml = XDocument.Load(@"EngLearn.xml");
            var query = from a in xml.Root.Elements("Lekcja")
                        where a.Attribute("name").Value == listaLekcji.Text
                        select a;

            iloscElementow = 0;
            foreach (var lista_slow in query.Elements("word").Attributes("PLword"))
            {
                iloscElementow++;
            }

            if (listaLekcji.Text == "")
            {
                info.Text = "Wybierz lekcje którą chcesz rozpocząć.";
                info.ForeColor = Color.Red;
                info.Visible = true;
            }
            else if (iloscElementow == 0)
            {
                info.Text = "Brak słówek w lekcji!";
                info.ForeColor = Color.Red;
                info.Visible = true;
            }
            else
            {
                if (czas.Checked == true)
                {
                    poczatek = new DateTime(DateTime.Now.Ticks);
                    timer1.Enabled = true;
                    stoper.Visible = true;
                }
                else stoper.Visible = false;

                l_bledow = 0;
                l_razem = 0;
                l_trafien = 0;
                trafienia.Visible = true;
                trafienia_amount.Visible = true;
                trafienia_amount.Text = "0";
                bledy.Visible = true;
                bledy_amount.Visible = true;
                bledy_amount.Text = "0";
                razem.Visible = true;
                razem_amount.Visible = true;
                razem_amount.Text = "0";
                pausa.Visible = true;
                wyslij.Visible = true;
                tlumaczenie.Visible = true;
                slowo.Visible = true;
                licznik.Visible = true;
                start_lekcja.Visible = false;
                stop.Visible = true;
                groupBox2.Enabled = false;
                info.ForeColor = Color.Green;
                info.Text = "Lekcja została poprawnie rozpoczęta.";
                info.Visible = true;

                slowoENG = new string[iloscElementow];
                slowoPL = new string[iloscElementow];
                flagi = new bool[iloscElementow];
                int i = 0;
                foreach (var lista_slow in query.Elements("word").Attributes("ENGword"))
                {
                    flagi[i] = false;
                    slowoENG[i] = lista_slow.Value;
                    i++;
                }
                i = 0;
                foreach (var lista_slow in query.Elements("word").Attributes("PLword"))
                {
                    slowoPL[i] = lista_slow.Value;
                    i++;
                }
                los = losowanie.Next(0, iloscElementow - 1);
                if (PL_ENG.Checked)
                {
                    slowo.Text = slowoPL[los];

                }
                else if (ENG_PL.Checked)
                {
                    slowo.Text = slowoENG[los];
                }
                liczba = "";
                liczba += "0/";
                liczba += iloscElementow.ToString();
                licznik.Text = liczba;
            }
            #endregion
        }

        private void wyslij_Click(object sender, EventArgs e)
        {
            #region przycisk - sprawdz
            if (iloscLosowan < iloscElementow)
            {
                if (PL_ENG.Checked)
                {
                    if (tlumaczenie.Text == slowoENG[los])
                    {
                        iloscLosowan++;
                        flagi[los] = true;
                        l_trafien++;
                        l_razem++;
                        trafienia_amount.Text = l_trafien.ToString();
                        razem_amount.Text = l_razem.ToString();
                        lekcja_info.Text = "Dobrze!";
                        lekcja_info.ForeColor = Color.Green;
                        lekcja_info.Visible = true;
                        tlumaczenie.Text = "";
                        liczba = "";
                        liczba += l_trafien.ToString();
                        liczba += "/";
                        liczba += iloscElementow.ToString();
                        licznik.Text = liczba;

                        while (flagi[los] && iloscLosowan < iloscElementow) los = losowanie.Next(0, iloscElementow);

                        slowo.Text = slowoPL[los];

                        if (iloscLosowan == iloscElementow)
                        {
                            slowo.Visible = false;
                            tlumaczenie.Visible = false;
                            wyslij.Visible = false;
                            stop.Visible = false;
                            start_lekcja.Visible = true;
                            groupBox2.Enabled = true;
                            if (czas.Checked == true)
                            {
                                timer1.Enabled = false;
                                sekundy = 0;
                                minuty = 0;
                                godziny = 0;
                                text_sekundy = ":00";
                                text_minuty = ":00";
                                text_godziny = "00";
                            }
                            iloscLosowan = 0;
                            iloscElementow = 0;
                            int i = 0;
                            foreach (string item in slowoPL)
                            {
                                slowoPL[i] = null;
                                slowoENG[i] = null;
                                flagi[i] = false;
                                i++;
                            }
                            info.Text = "Lekcja została zakończona!";
                            info.ForeColor = Color.Green;
                            lekcja_info.Text = "BRAWO!";
                            pausa.Visible = false;
                        }
                    }
                    else
                    {
                        l_razem++;
                        l_bledow++;
                        bledy_amount.Text = l_bledow.ToString();
                        razem_amount.Text = l_razem.ToString();
                        lekcja_info.Text = "Źle!";
                        lekcja_info.ForeColor = Color.Red;
                        lekcja_info.Visible = true;
                        tlumaczenie.Text = "";
                    }
                }
                else if (ENG_PL.Checked)
                {
                    if (tlumaczenie.Text == slowoPL[los])
                    {
                        iloscLosowan++;
                        flagi[los] = true;
                        l_trafien++;
                        l_razem++;
                        trafienia_amount.Text = l_trafien.ToString();
                        razem_amount.Text = l_razem.ToString();
                        lekcja_info.Text = "Dobrze!";
                        lekcja_info.ForeColor = Color.Green;
                        lekcja_info.Visible = true;
                        tlumaczenie.Text = "";
                        liczba = "";
                        liczba += l_trafien.ToString();
                        liczba += "/";
                        liczba += iloscElementow.ToString();
                        licznik.Text = liczba;

                        while (flagi[los] && iloscLosowan < iloscElementow) los = losowanie.Next(0, iloscElementow);

                        slowo.Text = slowoENG[los];

                        if (iloscLosowan == iloscElementow)
                        {
                            slowo.Visible = false;
                            tlumaczenie.Visible = false;
                            wyslij.Visible = false;
                            stop.Visible = false;
                            start_lekcja.Visible = true;
                            groupBox2.Enabled = true;
                            if (czas.Checked == true)
                            {
                                timer1.Enabled = false;
                                sekundy = 0;
                                minuty = 0;
                                godziny = 0;
                                text_sekundy = ":00";
                                text_minuty = ":00";
                                text_godziny = "00";
                            }
                            iloscLosowan = 0;
                            iloscElementow = 0;
                            int i = 0;
                            foreach (string item in slowoPL)
                            {
                                slowoPL[i] = null;
                                slowoENG[i] = null;
                                flagi[i] = false;
                                i++;
                            }
                            info.Text = "Lekcja została zakończona!";
                            info.ForeColor = Color.Green;
                            lekcja_info.Text = "BRAWO!";
                            pausa.Visible = false;
                        }
                    }
                    else
                    {
                        l_razem++;
                        l_bledow++;
                        bledy_amount.Text = l_bledow.ToString();
                        razem_amount.Text = l_razem.ToString();
                        lekcja_info.Text = "Źle!";
                        lekcja_info.ForeColor = Color.Red;
                        lekcja_info.Visible = true;
                        tlumaczenie.Text = "";
                    }
                }
            }
            #endregion
        }

        private void stop_Click(object sender, EventArgs e)
        {
            #region STOP lekcja
            slowo.Visible = false;
            tlumaczenie.Visible = false;
            wyslij.Visible = false;
            stop.Visible = false;
            start_lekcja.Visible = true;
            groupBox2.Enabled = true;
            if (czas.Checked == true)
            {
                timer1.Enabled = false;
                sekundy = 0;
                minuty = 0;
                godziny = 0;
                text_sekundy = ":00";
                text_minuty = ":00";
                text_godziny = "00";
            }
            iloscLosowan = 0;
            iloscElementow = 0;
            int i = 0;
            foreach (string item in slowoPL)
            {
                slowoPL[i] = null;
                slowoENG[i] = null;
                flagi[i] = false;
                i++;
            }
            info.Text = "Lekcja została zakończona!";
            info.ForeColor = Color.Black;
            pausa.Visible = false;
            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region czasomierz
            ts = DateTime.Now - poczatek;
            if(sekundy == 60)
            {
                sekundy = 0;
                minuty++;
                if(minuty < 10) text_minuty = ":0" + minuty.ToString();
                else text_minuty = ":" + minuty.ToString();
            }
            if(minuty == 60)
            {
                minuty = 0;
                godziny++;
                if(godziny < 10) text_godziny = "0" + godziny.ToString();
                else text_godziny = godziny.ToString();
            }
            sekundy++;
            if(sekundy < 10) text_sekundy = ":0" + sekundy.ToString();
                else text_sekundy = ":" + sekundy.ToString();

            stoper.Text = text_godziny + text_minuty + text_sekundy;
            #endregion
        }

        private void pausa_Click(object sender, EventArgs e)
        {
            if (czas.Checked) timer1.Enabled = false;
            wznów.Visible = true;
            pausa.Visible = false;
            stop.Enabled = false;
            tlumaczenie.Enabled = false;
            wyslij.Enabled = false;
        }

        private void wznów_Click(object sender, EventArgs e)
        {
            wznów.Visible = false;
            pausa.Visible = true;
            stop.Enabled = true;
            tlumaczenie.Enabled = true;
            wyslij.Enabled = true;
            timer1.Start();
        }




    }
}
