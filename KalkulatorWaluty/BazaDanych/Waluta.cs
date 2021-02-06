using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalkulatorWaluty.BazaDanych
{
    public class Waluta
    {
        public Waluta() { }
        public Waluta(int id, string nazwa, string symbol, double przelicznik)
        {
            Id = id;
            Nazwa = nazwa;
            Symbol = symbol;
            PrzelicznikDoDolara = przelicznik;
        }

        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Symbol { get; set; }
        public double PrzelicznikDoDolara { get; set; }
    }
}
