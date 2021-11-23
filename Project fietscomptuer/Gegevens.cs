using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_fietscomptuer
{
    class Gegevens
    {
        public static void BestandOpslaan(string bestand, List<string> gegevens)
        {
            bool bestaatBestand = Directory.Exists(bestand);
            string bestandPath = bestand.Remove(bestand.Length - 10, 10);
            if (bestaatBestand == false) Directory.CreateDirectory(bestandPath);
            StreamWriter bestandSchrijven = new StreamWriter(bestand);
            bestandSchrijven.WriteLine(gegevens[0]);
            bestandSchrijven.WriteLine(gegevens[1]);
            bestandSchrijven.WriteLine(gegevens[2]);
            bestandSchrijven.WriteLine(gegevens[3]);
            bestandSchrijven.Close();
        }
        public static void BestandInlezen(string bestand, List<string> gegevens)
        {
            StreamReader bestandLezen = new StreamReader(bestand);
            do
            {
                gegevens.Add(bestandLezen.ReadLine());
            }
            while (!bestandLezen.EndOfStream);
            bestandLezen.Close();
        }
    }
}
