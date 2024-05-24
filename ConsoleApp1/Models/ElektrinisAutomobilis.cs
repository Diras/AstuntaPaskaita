using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPaskaita.Models
{
    internal class ElektrinisAutomobilis: Automobilis
    {
        private double BaterijosKrovimoLaikas {  get; set; }

        public ElektrinisAutomobilis(string marke, string modelis, int metai, decimal kainaUzDiena, double baterijosKrovimoLaikas)
           : base(marke, modelis, metai, kainaUzDiena)
        {
            BaterijosKrovimoLaikas = baterijosKrovimoLaikas;
        }

        public double GetBaterijosKrovimoLaikas()
        {
            return BaterijosKrovimoLaikas;
        }

        public void SetBaterijosKrovimoLaikas(double baterijosKrovimoLaikas)
        {
            BaterijosKrovimoLaikas = baterijosKrovimoLaikas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Baterijos krovimo kaikas: {BaterijosKrovimoLaikas} Val.";
        }

    }
}
