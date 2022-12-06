using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcLibrary.Models;

namespace MvcLibrary.Controllers
{
    [Route("[controller]")]
    public class LivresController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Livres"] = Livres.ObtenirLivres();
            return View();
        }
        [HttpGet("/Livres/{id:int}")]
        public IActionResult DetailLivre(int id)
        {
            ViewData["Id"]=id;
            Livre livre = Livres.ObtenirLivres().FirstOrDefault(l=> l.Id == id);
            ViewData["Title"]=livre.Title;
            ViewData["Author"]=livre.Author;
            ViewData["Year"]=livre.Year;
            ViewData["Price"]=livre.Price;
            return View();
        }


        [HttpGet("/Livres/Supprimer/{id:int}")]
        public IActionResult SupprimerLivre(int id)
        {
            Livre livre = Livres.ObtenirLivres().FirstOrDefault(l=> l.Id == id);
            Livres.Supprimer(livre);
            return RedirectToAction("");
        }
        
        [HttpGet("/Livres/AjouterLivre")]
        public IActionResult AjouterLivre()
        {
           return View();
        }

        [HttpGet("/Livres/ValiderAjouterLivre")]
        public IActionResult ValiderAjouterLivre(string title,
         string author, int year, int price)
        {
            Livres.Ajouter(title, author, year,price);
            return RedirectToAction("");
        }
    }
}