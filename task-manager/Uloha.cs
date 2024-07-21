using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TaskManager
{
    public class Uloha
    {
        public int idUlohy { get; set; }
        public string nazovUlohy { get; set; }
        public bool hotova { get; set; }
        public string kontajner { get; set; }
        public string priebeh { get; set; }
        public string priorita { get; set; }
        public string opakovat { get; set; }
        public string poznamka { get; set; }
        public DateTime pociatocnyDatum { get; set; }
        public DateTime terminDokoncenia { get; set; }
    }
    public class UlohaManager
    {
        private static string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "uloha.xml");
        
        public static bool UlozDoXml(List<Uloha> ulohy)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Uloha>));
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, ulohy);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }     
        }

        public static List<Uloha> NacitajZXml()
        {
            if (!File.Exists(fileName))
            {
                return new List<Uloha>();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Uloha>));
            using (StreamReader reader = new StreamReader(fileName))
            {
                return (List<Uloha>)serializer.Deserialize(reader);
            }
        }

        public static void PridajUlohu(Uloha novaUloha)
        {
            List<Uloha> ulohy = NacitajZXml();
            ulohy.Add(novaUloha);
            UlozDoXml(ulohy);
        }

        public static void AktualizujUlohu(Uloha aktualizovanaUloha)
        {
            List<Uloha> ulohy = NacitajZXml();
            var existujucaUloha = ulohy.Find(u => u.idUlohy == aktualizovanaUloha.idUlohy);
            if (existujucaUloha != null)
            {
                ulohy.Remove(existujucaUloha);
                ulohy.Add(aktualizovanaUloha);
                UlozDoXml(ulohy);
            }
        }

        public static void OdstranitUlohu(int idUlohy)
        {
            List<Uloha> ulohy = NacitajZXml();
            var ulohaNaOdstranenie = ulohy.Find(u => u.idUlohy == idUlohy);
            if (ulohaNaOdstranenie != null)
            {
                ulohy.Remove(ulohaNaOdstranenie);
                UlozDoXml(ulohy);
            }
        }

        public static void PrintUlohaDetails(Uloha uloha)
        {
            Console.WriteLine($"ID: {uloha.idUlohy}");
            Console.WriteLine($"Názov Úlohy: {uloha.nazovUlohy}");
            Console.WriteLine($"Hotová: {uloha.hotova}");
            Console.WriteLine($"Kontajner: {uloha.kontajner}");
            Console.WriteLine($"Priebeh: {uloha.priebeh}");
            Console.WriteLine($"Priorita: {uloha.priorita}");
            Console.WriteLine($"Opakovať: {uloha.opakovat}");
            Console.WriteLine($"Počiatočný Dátum: {uloha.pociatocnyDatum}");
            Console.WriteLine($"Termín Dokončenia: {uloha.terminDokoncenia}");
        }
    }
}

