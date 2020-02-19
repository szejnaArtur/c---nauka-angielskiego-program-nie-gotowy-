using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EngLaern
{
    class DataClass
    {
        public static XDocument createData()
        {
            XDocument myDocument = new XDocument(
                new XDeclaration("1.0", "utf8", "yes"),
                new XElement("Lekcje",
                    new XElement("Lekcja",
                        new XAttribute("name", "Kolory"),
                        new XElement("word",
                            new XAttribute("PLword", "czerwony"),
                            new XAttribute("ENGword", "red")),
                        new XElement("word",
                            new XAttribute("PLword", "zielony"),
                            new XAttribute("ENGword", "green")),
                        new XElement("word",
                            new XAttribute("PLword", "niebieski"),
                            new XAttribute("ENGword", "blue")),
                        new XElement("word",
                            new XAttribute("PLword", "żółty"),
                            new XAttribute("ENGword", "yellow")),
                        new XElement("word",
                            new XAttribute("PLword", "biały"),
                            new XAttribute("ENGword", "white")),
                        new XElement("word",
                            new XAttribute("PLword", "złoty"),
                            new XAttribute("ENGword", "golden")),
                        new XElement("word",
                            new XAttribute("PLword", "pomarańczowy"),
                            new XAttribute("ENGword", "orange")),
                        new XElement("word",
                            new XAttribute("PLword", "karmazynowy"),
                            new XAttribute("ENGword", "crimson")),
                        new XElement("word",
                            new XAttribute("PLword", "szkarłatny"),
                            new XAttribute("ENGword", "scarlet")),
                        new XElement("word",
                            new XAttribute("PLword", "bordo"),
                            new XAttribute("ENGword", "claret")),
                        new XElement("word",
                            new XAttribute("PLword", "fioletowy"),
                            new XAttribute("ENGword", "violet")),
                        new XElement("word",
                            new XAttribute("PLword", "purpurowy"),
                            new XAttribute("ENGword", "purple")),
                        new XElement("word",
                            new XAttribute("PLword", "oliwkowy"),
                            new XAttribute("ENGword", "olive")),
                        new XElement("word",
                            new XAttribute("PLword", "kasztanowy"),
                            new XAttribute("ENGword", "maroon")),
                        new XElement("word",
                            new XAttribute("PLword", "szary"),
                            new XAttribute("ENGword", "grey")),
                        new XElement("word",
                            new XAttribute("PLword", "srebrny"),
                            new XAttribute("ENGword", "silver")),
                        new XElement("word",
                            new XAttribute("PLword", "czarny"),
                            new XAttribute("ENGword", "black")),
                        new XElement("word",
                            new XAttribute("PLword", "różowy"),
                            new XAttribute("ENGword", "pink")
                        )
                    ),
                    new XElement("Lekcja",
                        new XAttribute("name", "Pojazdy"),
                        new XElement("word",
                            new XAttribute("PLword", "taksówka"),
                            new XAttribute("ENGword", "taxi")),
                        new XElement("word",
                            new XAttribute("PLword", "motorówka "),
                            new XAttribute("ENGword", "motorboat")),
                        new XElement("word",
                            new XAttribute("PLword", "statek "),
                            new XAttribute("ENGword", "ship")),
                        new XElement("word",
                            new XAttribute("PLword", "prom "),
                            new XAttribute("ENGword", "ferry")),
                        new XElement("word",
                            new XAttribute("PLword", "motor"),
                            new XAttribute("ENGword", "motorbike")),
                        new XElement("word",
                            new XAttribute("PLword", "wagon"),
                            new XAttribute("ENGword", "carriage")),
                        new XElement("word",
                            new XAttribute("PLword", "łódź"),
                            new XAttribute("ENGword", "boat")),
                        new XElement("word",
                            new XAttribute("PLword", "samochód "),
                            new XAttribute("ENGword", "car")),
                        new XElement("word",
                            new XAttribute("PLword", "karawan"),
                            new XAttribute("ENGword", "caravan")),
                        new XElement("word",
                            new XAttribute("PLword", "autobus"),
                            new XAttribute("ENGword", "bus")),
                        new XElement("word",
                            new XAttribute("PLword", "autokar"),
                            new XAttribute("ENGword", "coach")),
                        new XElement("word",
                            new XAttribute("PLword", "ciężarówka"),
                            new XAttribute("ENGword", "lorry")),
                        new XElement("word",
                            new XAttribute("PLword", "helikopter"),
                            new XAttribute("ENGword", "helicopter")),
                        new XElement("word",
                            new XAttribute("PLword", "karetka pogotowia"),
                            new XAttribute("ENGword", "ambulance")),
                        new XElement("word",
                            new XAttribute("PLword", "pociąg"),
                            new XAttribute("ENGword", "train")),
                        new XElement("word",
                            new XAttribute("PLword", "rower"),
                            new XAttribute("ENGword", "bike")),
                        new XElement("word",
                            new XAttribute("PLword", "samolot"),
                            new XAttribute("ENGword", "plane")),
                        new XElement("word",
                            new XAttribute("PLword", "żaglówka"),
                            new XAttribute("ENGword", "sailing boat")
                        )
                    )
                )
            );
            return myDocument;
        }

        public static void addLesson(string name, string filename)
        {
            XDocument xml = XDocument.Load(filename);
            XElement nowy = xml.Root;
            nowy.Add(new XElement("Lekcja",
                new XAttribute("name", name)));
            xml.Save(filename);
        }

        public static void SaveData(string filename, XDocument xml)
        {
            xml.Save(filename);
        }

        public static void AddNewWord(string lekcja, string PLword, string ENGword, string filename)
        {
            XDocument xml = XDocument.Load(filename);
            var query = from a in xml.Descendants("Lekcja")
                        where a.Attribute("name").Value == lekcja
                        select a;

            foreach (var item in query)
            {
                item.Add(new XElement("word", new XAttribute("PLword", PLword), new XAttribute("ENGword", ENGword)));
            }
            xml.Save(filename);
        }

        public static void RemoveWord(string lekcja, string filename, int IP)
        {
            XDocument xml = XDocument.Load(filename);
            var query = from a in xml.Root.Elements("Lekcja")
                        where a.Attribute("name").Value == lekcja
                        select a.Elements("word").ElementAt(IP);

            foreach (var item in query)
            {
                item.Remove();
            }
            xml.Save(filename);
        }

        public static void ChangeWord(string lekcja, string filename, int IP, string PLword, string ENGword)
        {
            XDocument xml = XDocument.Load(filename);
            var query = from a in xml.Root.Elements("Lekcja")
                        where a.Attribute("name").Value == lekcja
                        select a.Elements("word").ElementAt(IP);

            foreach (var item in query)
            {
                item.Attribute("PLword").Value = PLword;
                item.Attribute("ENGword").Value = ENGword;
            }
            xml.Save("EngLearn.xml");
        }

        public static void RemoveLesson(string lekcja, string filename)
        {
            XDocument xml = XDocument.Load(filename);
            var query = from a in xml.Root.Elements("Lekcja")
                        where a.Attribute("name").Value == lekcja
                        select a;

            foreach (var item in query)
            {
                item.Remove();
            }
            xml.Save(filename);
        }

    }
}
