using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record Indirizzo
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Province { get; set; }
    public string ZIP { get; set; }

    public Indirizzo(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        ZIP = zip;
    }

    // Override per formattazione indirizzi
    public override string ToString()
    {
        return $"Indirizzo: {Name}, {Surname}, {Street}, {City}, {Province}, {ZIP}";
    }
}