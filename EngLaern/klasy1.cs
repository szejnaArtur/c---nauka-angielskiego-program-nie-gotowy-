using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Collections;

namespace EngLaern
{
    class Funkcje
    {
        public bool sprawdzNazweLekcji(string nazwaLekcji)
        {
            #region Sprawdzanie nazwy Lekcji - czy spełnia wymagania(niedozwolone znaki, powtarzanie sie nazw idp.)
            bool prawda = true;
            int ilosc = nazwaLekcji.Count();

            XDocument xml = XDocument.Load(@"EngLearn.xml");

            if (nazwaLekcji == "" || nazwaLekcji[0] == ' ') prawda = false;

            for (int i = 0; i < ilosc; i++)
            {
                if (nazwaLekcji[ilosc - 1] == ' ')
                {
                    prawda = false;
                    break;
                }

                if (nazwaLekcji[i] == ' ')
                {
                    if (i != ilosc - 1)
                    {
                        if (nazwaLekcji[i + 1] == ' ')
                        {
                            prawda = false;
                            break;
                        }
                    }
                }
            }

            foreach (var name in xml.Elements("Lekcje").Elements("Lekcja").Attributes("name"))
            {
                if (nazwaLekcji == name.Value)
                {
                    prawda = false;
                }
            }
            if (prawda) return true;
            else return false;
            #endregion
        }

        public bool sprawdzPoprawnosc(string sprawdzSlowoAng, string sprawdzSlowoPl)
        {
            #region Sprawdzanie słowek - czy spełnia wymagania(niedozwolone znaki, powtarzanie sie nazw idp.)
            bool prawda = true;
            int ilosc1 = sprawdzSlowoAng.Count();
            int ilosc2 = sprawdzSlowoPl.Count();

            if (sprawdzSlowoAng == "") prawda = false;
            if (sprawdzSlowoPl == "") prawda = false;

            for (int i = 0; i < ilosc1; i++)
            {
                if (sprawdzSlowoAng[0] == ' ')
                {
                    prawda = false;
                    break;
                }
                if (sprawdzSlowoAng[ilosc1 - 1] == ' ')
                {
                    prawda = false;
                    break;
                }

                if (sprawdzSlowoAng[i] == ' ')
                {
                    if (i != ilosc1 - 1)
                    {
                        if (sprawdzSlowoAng[i + 1] == ' ')
                        {
                            prawda = false;
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < ilosc2; i++)
            {
                if (sprawdzSlowoPl[0] == ' ')
                {
                    prawda = false;
                    break;
                }
                if (sprawdzSlowoPl[ilosc2 - 1] == ' ')
                {
                    prawda = false;
                    break;
                }

                if (sprawdzSlowoPl[i] == ' ')
                {
                    if (i != ilosc2 - 1)
                    {
                        if (sprawdzSlowoPl[i + 1] == ' ')
                        {
                            prawda = false;
                            break;
                        }
                    }
                }
            }
            if (prawda) return true;
            else return false;
            #endregion
        }


    }
}
