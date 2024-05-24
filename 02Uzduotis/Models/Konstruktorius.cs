using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Konstruktorius : Zaislas
    {
        
        private KonstruktoriausTipasEnum KonstruktoriausTipas;

        public Konstruktorius(string pavadinimas, string gamintojas, int amziausRiba, decimal kaina, KonstruktoriausTipasEnum konstruktoriausTipas)
            : base(pavadinimas, gamintojas, amziausRiba, kaina)
        {
            KonstruktoriausTipas = konstruktoriausTipas;
        }

        public KonstruktoriausTipasEnum GetKonstruktoriausTipas()
        {
            return KonstruktoriausTipas;
        }

        public void SetKonstruktoriausTipas(KonstruktoriausTipasEnum konstruktoriausTipas)
        {
            KonstruktoriausTipas = konstruktoriausTipas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Detalės skaičius: {KonstruktoriausTipas}";
        }
    }
}
