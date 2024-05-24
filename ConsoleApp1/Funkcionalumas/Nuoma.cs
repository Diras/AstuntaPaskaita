using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstuntaPaskaita.Models;

namespace Funkcionalumas
{
    public class Nuoma
    {
        private List<Automobilis> TurimiAutomobiliai;

        public Nuoma()
        {
            TurimiAutomobiliai = new List<Automobilis>();
        }

        public List<Automobilis> GetTurimiAutomobiliai()
        {
            return TurimiAutomobiliai;
        }


        public void PridetiAutomobili(List<Automobilis> sarasas, Automobilis automobilis)
        {
            sarasas.Add(automobilis);
            Console.WriteLine("Automobilis pridėtas sėkmingai.");
        }


        public Automobilis PaimtiAutomobili(List<Automobilis> sarasas, int indeksas)
        {

            if (indeksas >= 0 && indeksas < sarasas.Count)
            {
                Automobilis pasirinktasAutomobilis = sarasas[indeksas];
                Console.WriteLine("Automobilis paimtas sėkmingai.");
                return pasirinktasAutomobilis;
            }
            else
            {
                Console.WriteLine("Netinkamas indeksas. Automobilis nerastas.");
                return null;
            }
        }

        public decimal ApskaiciuotiNuomosKaina(Automobilis automobilis, int dienuSkaicius)
        {
            return automobilis.GetKainaUzDiena() * dienuSkaicius;
        }


        public virtual void RodytiVisusAutomobilius()
        {
            if (TurimiAutomobiliai.Count == 0)
            {
                Console.WriteLine("Sąrašas tuščias.");
            }
            else
            {
                for (int i = 0; i < TurimiAutomobiliai.Count; i++)
                {
                    Console.WriteLine($"Indeksas: {i}. {TurimiAutomobiliai[i]}");
                }
            }
        }
    }
}
