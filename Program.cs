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
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(',');

        if (values.Length == 6)
        {
            string name = string.IsNullOrEmpty(values[0].Trim()) ? "NO DATA" : values[0].Trim();
            string surname = string.IsNullOrEmpty(values[1].Trim()) ? "NO DATA" : values[1].Trim();
            string street = string.IsNullOrEmpty(values[2].Trim()) ? "NO DATA" : values[2].Trim();
            string city = string.IsNullOrEmpty(values[3].Trim()) ? "NO DATA" : values[3].Trim();
            string province = string.IsNullOrEmpty(values[4].Trim()) ? "NO DATA" : values[4].Trim();
            string zip = string.IsNullOrEmpty(values[5].Trim()) ? "NO DATA" : values[5].Trim();

            // Aggiunta dell'indirizzo alla lista
            indirizzi.Add(new Indirizzo(name, surname, street, city, province, zip));
        }
        else
        {
            Console.WriteLine("Riga non valida: " + line);
        }
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
