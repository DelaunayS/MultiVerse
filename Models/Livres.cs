using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLibrary.Models
{
    public static class Livres
    {
        public static int IdCpt=2;
        public static List<Livre> ListeLivres = new List<Livre>{
            new Livre{
                Id = 1,Title="L'étranger",Author="Camus",
                Year= 1942, Price=9},
            new Livre{
            Id = 2,Title="Voyage au centre de la terre",Author="Verne",
            Year= 1864, Price=7}
        };

        public static List<Livre> ObtenirLivres()
        {
            return ListeLivres;
        }

        public static void Supprimer(Livre livre)
        {
            ListeLivres.Remove(livre);
        }
        public static void Ajouter(string title, string author,int year, int price)
        {
            IdCpt++;
            Livre livre = new Livre{
                Id=IdCpt,Title=title,Author=author,Year=year,Price=price
            };
            ListeLivres.Add(livre);
        }

    }

}