using System;
using System.Collections.Generic;
using System.IO;

// Lista indirizzo
List<Indirizzo> indirizzi = new List<Indirizzo>();

// path per raggiungere il file csv dalla cartella dell'exe
string adressPath = @"..\\..\\..\\addresses.csv";

// Lettura e inserimento dati dal file csv
using (var reader = new StreamReader(adressPath))
{
    reader.ReadLine();

    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line?.Split(',');

        string name = !string.IsNullOrEmpty(values[0]) ? values[0] : "NO DATA";
        string surname = !string.IsNullOrEmpty(values[1]) ? values[1] : "NO DATA";
        string street = !string.IsNullOrEmpty(values[2]) ? values[2] : "NO DATA";
        string city = values.Length >= 4 ? values[3] : "NO DATA";
        string province = values.Length >= 5 ? values[4] : "NO DATA";
        string zip = values.Length >= 6 ? values[5] : "NO DATA";

        indirizzi.Add(new Indirizzo(name, surname, street, city, province, zip));
    }
}

foreach (var indirizzo in indirizzi)
{
    Console.WriteLine(indirizzo.ToString());
}

// Lista degli indirizzi in file txt
using StreamWriter output = File.CreateText("..\\..\\..\\indirizzi.txt");
foreach (var indirizzo in indirizzi)
{
    output.WriteLine(indirizzo);
}
