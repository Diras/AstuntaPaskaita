using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstuntaPaskaita.Models
{
    public class NaftosKuroAutomobilis: Automobilis
    {
        private double DegaluSunaudojimas {  get; set; }

        public NaftosKuroAutomobilis(string marke, string modelis, int metai, decimal kainaUzDiena, double degaluSunaudojimas)
            : base(marke, modelis, metai, kainaUzDiena)
        {
            DegaluSunaudojimas = degaluSunaudojimas;
        }

        public double GetDegaluSunaudojimas()
        {
            return DegaluSunaudojimas;
        }

        public void SetDegaluSunaudojimas(double degaluSunaudojimas)
        {
            DegaluSunaudojimas = degaluSunaudojimas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Degalų suvartojimas: {DegaluSunaudojimas} l/100km";
        }
    }
}

