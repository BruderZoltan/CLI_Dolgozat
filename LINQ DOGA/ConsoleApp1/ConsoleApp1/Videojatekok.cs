using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleApp1
{
    internal class Videojatekok
    {
        public string Cim {  get; set; }
        public string Mufaj { get; set; }
        public DateTime KiadasDatum { get; set; }
        public int AktivJatekosok { get; set; }
        public float Ertekeles { get; set; }

        public override string ToString() =>
            $"\tCim: {Cim}\n" +
            $"\tMufaj: {Mufaj}\n" +
            $"\tKiadasDatum: {KiadasDatum}\n" +
            $"\tAktivJatekosok: {AktivJatekosok}\n" +
            $"\tErtkeles: {Ertekeles}\n";



        //public Videojatekok(string sor)
        //{
        //    var tmp = sor.Split(','); 
        //    Cim = tmp[0];
        //    Mufaj = tmp[1];
        //    KiadasDatum = DateTime.Parse(tmp[2]);
        //    AktivJatekosok = int.Parse(tmp[3]);
        //    Ertekeles = Double.Parse(tmp[4]);
            
          
        //}
    }
}
