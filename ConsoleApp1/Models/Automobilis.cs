using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPaskaita.Models
{
    public class Automobilis
    {
        
        private string Marke { get; set; }
        private string Modelis { get; set; }
        private int Metai { get; set; }
        private decimal KainaUzDiena { get; set; }

        
        public Automobilis(string marke, string modelis, int metai, decimal kainaUzDiena)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            KainaUzDiena = kainaUzDiena;
        }

        
        public string GetMarke()
        {
            return Marke;
        }

        public void SetMarke(string marke)
        {
            Marke = marke;
        }

        public string GetModelis()
        {
            return Modelis;
        }

        public void SetModelis(string modelis)
        {
            Modelis = modelis;
        }

        public int GetMetai()
        {
            return Metai;
        }

        public void SetMetai(int metai)
        {
            Metai = metai;
        }

        public decimal GetKainaUzDiena()
        {
            return KainaUzDiena;
        }

        public void SetKainaUzDiena(decimal kainaUzDiena)
        {
            KainaUzDiena = kainaUzDiena;
        }

        
        public override string ToString()
        {
            return $"Marke: {Marke}, Modelis: {Modelis}, Metai: {Metai}, Kaina už dieną: {KainaUzDiena} Eur";
        }
    }
}
