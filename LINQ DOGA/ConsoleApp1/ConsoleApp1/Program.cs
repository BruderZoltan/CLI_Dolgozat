
using ConsoleApp1;

List<Videojatekok> videojatekok = [];

const string FilePath = "..\\..\\..\\data\\videogames.csv";

using StreamReader sr = new(FilePath);
_ = sr.ReadLine();
while (!sr.EndOfStream)
{
    var tmp = sr.ReadLine().Split(',');
    videojatekok.Add(new()
    {
        Cim = tmp[0],
        Mufaj = tmp[1],
        KiadasDatum = DateTime.Parse(tmp[2]),
        AktivJatekosok = int.Parse(tmp[3]),
        Ertekeles = float.Parse(tmp[4].Replace('.',','))
    });
}

//1.feladat
var ertekeles = videojatekok.Count(p => p.Ertekeles > 4.5);
Console.WriteLine($"\nEnnyi jateknak lett nagyobb az ertekelese mint 4,5:  {ertekeles}");

//2.feladat
var legtobbj = videojatekok.MaxBy(p => p.AktivJatekosok);
Console.WriteLine($"\nEzt a jatekot jatszak a legtobben: {legtobbj}");

//3.feladat
var vane = videojatekok.Any(p => p.KiadasDatum.Year <  2020);
Console.WriteLine($"\nVan e jatek ami 2020 januar 1. elott jelent meg: {vane}");

//4.feladat
var atlag = videojatekok.Sum(p =>  p.Ertekeles);
Console.WriteLine($"\nErtekeleseknek az atlaga: {atlag}");

//5.feladat
var adottjatek = videojatekok.Single(p => p.Cim == "Cyber City 2077");
Console.WriteLine($"\nAz a jatek aminek a neve Cyber City 2077: \n{adottjatek}");