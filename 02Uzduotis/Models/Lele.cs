using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Models
{
    public class Lele : Zaislas
    {
        private SukosenosEnum SukosenosTipas;

        public Lele(string pavadinimas, string gamintojas, int amziausRiba, decimal kaina, SukosenosEnum sukosenosTipas)
            : base(pavadinimas, gamintojas, amziausRiba, kaina)
        {
            SukosenosTipas = sukosenosTipas;
        }

        public SukosenosEnum GetSukosenosTipas()
        {
            return SukosenosTipas;
        }

        public void SetSukosenosTipas(SukosenosEnum sukosenosTipas)
        {
            SukosenosTipas = sukosenosTipas;
        }

        public override string ToString()
        {
            return base.ToString() + $", Šukuosenos tipas: {SukosenosTipas}";
        }
    }
}
