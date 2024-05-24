using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcionalas
{
    public class Parduotuve
    {
        private List<Zaislas> ZaisluSarasas {  get; set; }
        public Parduotuve() 
        {
            ZaisluSarasas = new List<Zaislas>();
        }

        public List<Zaislas> GetZaisluSarasas()
        {
            return ZaisluSarasas;
        }

        public void SetZaisluSarasas(List<Zaislas> zaisluSarasas)
        {
            ZaisluSarasas = zaisluSarasas;
        }

        public void PridetiNaujaZaisla(Zaislas zaislas)
        {
            ZaisluSarasas.Add(zaislas);
        }

        public void PaimtiIrApskaiciuoti(int indeksas, int kiekis)
        {
            decimal suma = 0;
            suma = ZaisluSarasas[indeksas].GetKaina() * kiekis;
            Console.WriteLine($"Bendra kaina: {suma}");
        }
    }
}
