using Contracts;
using Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcionalas
{
    public class DarbarSuFailais : ITextas
    {
        private readonly string _failoVieta;

        private StreamReader _reader;
        private StreamWriter _writer;

        public DarbarSuFailais(string failoVieta)
        {
            _failoVieta = failoVieta;
        }


        public List<Zaislas> NuskaitytiVisusZaislus()
        {
            List<Zaislas> sarasas = new List<Zaislas>();
            
            if (!File.Exists(_failoVieta))
            {
                Console.WriteLine("Failas nerastas. Grąžinamas tuščias sąrašas.");
                return sarasas;
            }

            _reader = new StreamReader(_failoVieta);
            string eilute;

            while ((eilute = _reader.ReadLine()) != null)
            {
                string[] reiksmes = eilute.Split(',');
                if (reiksmes.Length == 5)
                {
                    if (reiksmes[4] is SukosenosEnum)
                    {
                        sarasas.Add(new Lele(reiksmes[0], reiksmes[1], int.Parse(reiksmes[2]), decimal.Parse(reiksmes[3]), Enum.Parse<SukosenosEnum>(reiksmes[4])));
                    }
                    else
                    {
                        sarasas.Add(new Konstruktorius(reiksmes[0], reiksmes[1], int.Parse(reiksmes[2]), decimal.Parse(reiksmes[3]), Enum.Parse<KonstruktoriausTipasEnum>(reiksmes[4])));
                    }
                }
                else
                {
                    sarasas.Add(new Zaislas(reiksmes[0], reiksmes[1], int.Parse(reiksmes[2]), decimal.Parse(reiksmes[3])));
                }
                
            }
            _reader.Close();
            Console.WriteLine("Sekmingai nuskaityta is failo!");
            return sarasas;
        }

        public void SpausdintiZaislusIFaila(List<Zaislas> sarasas)
        {
            _writer = new StreamWriter(_failoVieta);

            foreach (Zaislas zaislas in sarasas)
            {
                if (zaislas is Lele lele)
                {
                    _writer.WriteLine($"{lele.GetPavadinimas()},{lele.GetGamintojas},{lele.GetAmziausRiba()},{lele.GetKaina()},{lele.GetSukosenosTipas()}");
                }
                else if (zaislas is Konstruktorius konstruktorius)
                {
                    _writer.WriteLine($"{konstruktorius.GetPavadinimas()},{konstruktorius.GetGamintojas},{konstruktorius.GetAmziausRiba()},{konstruktorius.GetKaina()},{konstruktorius.GetKonstruktoriausTipas()}");
                }
                else
                {
                    _writer.WriteLine($"{zaislas.GetPavadinimas()},{zaislas.GetGamintojas},{zaislas.GetAmziausRiba()},{zaislas.GetKaina()}");
                }
            }
        }

        public void SpausdintiKonstruktorius(List<Zaislas> sarasas)
        {
            foreach (Zaislas zaislas in sarasas)
            {
                if (zaislas is Konstruktorius konstruktorius)
                {
                    Console.WriteLine($"{konstruktorius}");
                }
            }
        }

        public void SpausdintiLeles(List<Zaislas> sarasas)
        {
            foreach (Zaislas zaislas in sarasas)
            {
                if (zaislas is Lele lele)
                {
                    Console.WriteLine($"{lele}");
                } 
            }
        }

        public void SpausdintiViska(List<Zaislas> sarasas)
        {
            for (int i = 0; i<sarasas.Count; i++)
            {
                if (sarasas[i] is Lele lele)
                {
                    Console.WriteLine($"Indeksas:{i} - {lele}");
                }
                else if (sarasas[i] is Konstruktorius konstruktorius)
                {
                    Console.WriteLine($"Indeksas:{i} - {konstruktorius}");
                }
                else
                {
                    Console.WriteLine($"Indeksas:{i} - {sarasas[i]}");
                }
            }
        }
    }
}
