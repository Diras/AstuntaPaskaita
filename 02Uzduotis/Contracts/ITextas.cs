using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    internal interface ITextas
    {
        void SpausdintiZaislusIFaila(List<Zaislas> sarasas);
        void SpausdintiKonstruktorius(List<Zaislas> sarasas);
        void SpausdintiLeles(List<Zaislas> sarasas);

        List<Zaislas> NuskaitytiVisusZaislus();
    }
}
