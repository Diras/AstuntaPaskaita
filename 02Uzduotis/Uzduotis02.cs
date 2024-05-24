using Funkcionalas;
using Models;
using System;

namespace ZaisluParduotuve
{
    public class Uzduotis02
    {
        public static void Main(string[] args) 
        {
            string parduotuvesFailoVieta = "ParduotuvesPrekes.txt";

            Parduotuve zaisluParduotuve = new Parduotuve();
            DarbarSuFailais darbarSuFailais = new DarbarSuFailais(parduotuvesFailoVieta);

            zaisluParduotuve.SetZaisluSarasas(darbarSuFailais.NuskaitytiVisusZaislus());
            if (zaisluParduotuve.GetZaisluSarasas().Count > 0 )
            {

            }
            else
            {
                zaisluParduotuve.PridetiNaujaZaisla(new Lele("Barbie", "KinijosFabrikas", 5, 9.99M, Enums.SukosenosEnum.Ilga));
                zaisluParduotuve.PridetiNaujaZaisla(new Lele("Barbie", "KinijosFabrikas", 5, 9.99M, Enums.SukosenosEnum.Trumpa));

                zaisluParduotuve.PridetiNaujaZaisla(new Konstruktorius("Konstruktorius", "KinijosKonstrFabrikas", 3, 5.99M, Enums.KonstruktoriausTipasEnum.LegoDuplo));
                zaisluParduotuve.PridetiNaujaZaisla(new Konstruktorius("Konstruktorius", "KinijosKonstrFabrikas", 10, 10.99M, Enums.KonstruktoriausTipasEnum.Lego));
                zaisluParduotuve.PridetiNaujaZaisla(new Konstruktorius("Konstruktorius", "KinijosKonstrFabrikas", 99, 99.99M, Enums.KonstruktoriausTipasEnum.LegoTechnic));

                zaisluParduotuve.PridetiNaujaZaisla(new Zaislas("Dviratis", "Rambynas", 21, 199.99M));
            }

            

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Konstruktoriu sarasas:");
            darbarSuFailais.SpausdintiKonstruktorius(zaisluParduotuve.GetZaisluSarasas());
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Leliu sarasas:");
            darbarSuFailais.SpausdintiLeles(zaisluParduotuve.GetZaisluSarasas());
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Visas sarasas:");
            darbarSuFailais.SpausdintiViska(zaisluParduotuve.GetZaisluSarasas());
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Iveskite zaislo indeksa kuri norite paimti apskaiciavimui:");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite kiek norite paimti vienetu:");
            int vienetai = int.Parse(Console.ReadLine());
            zaisluParduotuve.PaimtiIrApskaiciuoti(index, vienetai);

        }
    }
}