using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstuntaPaskaita.Models;

namespace Funkcionalumas
{
    public class Autoparkas : Nuoma
    {
        private List<Automobilis> VisiAutoparkoAutomobiliai;

        public Autoparkas()
        {
            VisiAutoparkoAutomobiliai = new List<Automobilis>();
        }

        public List<Automobilis> GetVisiAutoparkoAutomobiliai()
        {
            return VisiAutoparkoAutomobiliai;
        }



        public override void RodytiVisusAutomobilius()
        {
            if (VisiAutoparkoAutomobiliai.Count == 0)
            {
                Console.WriteLine("Sąrašas tuščias.");
            }
            else
            {
                for (int i = 0; i < VisiAutoparkoAutomobiliai.Count; i++)
                {
                    Console.WriteLine($"Indeksas: {i}. {VisiAutoparkoAutomobiliai[i]}");
                }
            }
        }
    }
}
