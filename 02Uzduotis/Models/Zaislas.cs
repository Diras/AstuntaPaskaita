using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Zaislas
    {
        private string Pavadinimas;
        private string Gamintojas;
        private int AmziausRiba;
        private decimal Kaina;

        public Zaislas() 
        {

        }

        public Zaislas(string pavadinimas, string gamintojas, int amziausRiba, decimal kaina)
        {
            Pavadinimas = pavadinimas;
            Gamintojas = gamintojas;
            AmziausRiba = amziausRiba;
            Kaina = kaina;
        }

        
        public string GetPavadinimas()
        {
            return Pavadinimas;
        }

        public void SetPavadinimas(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public string GetGamintojas()
        {
            return Gamintojas;
        }

        public void SetGamintojas(string gamintojas)
        {
            Gamintojas = gamintojas;
        }

        public int GetAmziausRiba()
        {
            return AmziausRiba;
        }

        public void SetAmziausRiba(int amziausRiba)
        {
            AmziausRiba = amziausRiba;
        }

        public decimal GetKaina()
        {
            return Kaina;
        }

        public void SetKaina(decimal kaina)
        {
            Kaina = kaina;
        }

        public override string ToString()
        {
            return $"Pavadinimas: {Pavadinimas}, Gamintojas: {Gamintojas}, Amžiaus riba: {AmziausRiba}, Kaina: {Kaina} Eur";
        }
    }
}
