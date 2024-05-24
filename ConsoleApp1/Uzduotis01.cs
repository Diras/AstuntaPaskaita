using AstuntaPaskaita.Models;
using Funkcionalumas;
using System;


namespace AstuntaPaskaita
{
    /*
     * Sukurkite automobilių nuomos sistemą. Jums reikės sukurti pagrindinę klasę Automobilis, 
     * kuri turės šiuos atributus: marke, modelis, metai ir kaina už dieną. Sukurkite reikiamus 
     * getterius ir setterius, taip pat konstruktorių, leidžiantį sukurti automobilio objektą su nurodytais atributais.

        Toliau sukurti dvi subklases, NaftosKuroAutomobilis ir ElektrinisAutomobilis. 
    Kiekviena subklasė turi papildomą atributą, pavyzdžiui, degalų suvartojimas 100 km 
    atstumu arba baterijos krovimo laikas. Taip pat, kiekviena subklasė turi turėti savo konstruktorių, 
    kuris prideda šiuos papildomus atributus, ir tinkamus getterius ir setterius.

        Galų gale, parašykite klasę Nuoma, kurioje yra sąrašas su turimais automobiliais. 
    Sukurti metodus, kurie leistų pridėti naujus automobilius į sąrašą, pasiimti automobilį 
    iš sąrašo ir apskaičiuoti nuomos kainą už nurodytą dienų skaičių.

        Pridėti viso autoparko atspausdinimą. Susikūrus klasę autoparkas prisidėti sąrašą automobilių.
     * */
    public class Uzduotis01
    {
        public static void Main(string[] args)
        {
            Autoparkas ernestoAutoparkas = new Autoparkas();
            Nuoma nuoma = new Nuoma();




            ernestoAutoparkas.PridetiAutomobili(ernestoAutoparkas.GetVisiAutoparkoAutomobiliai(), new NaftosKuroAutomobilis("Audi", "C5", 2002, 25, 17));
            ernestoAutoparkas.PridetiAutomobili(ernestoAutoparkas.GetVisiAutoparkoAutomobiliai(), new NaftosKuroAutomobilis("VW", "T3", 1983, 100, 10));
            ernestoAutoparkas.PridetiAutomobili(ernestoAutoparkas.GetVisiAutoparkoAutomobiliai(), new NaftosKuroAutomobilis("Nissan", "Note", 2007, 15, 7));
            ernestoAutoparkas.PridetiAutomobili(ernestoAutoparkas.GetVisiAutoparkoAutomobiliai(), new ElektrinisAutomobilis("Nissan", "Leaf", 2016, 50, 24));

            ernestoAutoparkas.RodytiVisusAutomobilius();
            Console.WriteLine("Pasirinkite automobilio indeksa kuri norite prideti i nuomos sarasa...");
            int indeksas = int.Parse(Console.ReadLine());
            nuoma.PridetiAutomobili(nuoma.GetTurimiAutomobiliai(), ernestoAutoparkas.PaimtiAutomobili(ernestoAutoparkas.GetVisiAutoparkoAutomobiliai(), indeksas));

            
            Console.WriteLine("Nuomos automobiliu sarasas:");
            nuoma.RodytiVisusAutomobilius();
            Console.WriteLine("Pasirinkite automobilio indeksa kurio nuomos kaina norite apskaiciuoti:");
            indeksas = int.Parse(Console.ReadLine());
            Console.WriteLine("Keliom denom norite paimti automobili?");
            int dienos = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nuomos kaina = {nuoma.ApskaiciuotiNuomosKaina(nuoma.GetTurimiAutomobiliai()[indeksas], dienos)}");

        }

        
    }
}