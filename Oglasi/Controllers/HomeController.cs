using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oglasi.Services;

namespace Oglasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOglasiServis _oglasiServis;

        public HomeController(IOglasiServis oglasiServis)
        {
            _oglasiServis = oglasiServis;
        }

        public async Task<IActionResult> Index()
        {
            var kategorije = await _oglasiServis.SveKategorije();
            var potkategorije = await _oglasiServis.SvePotkategorije();
            var oglasipotkategorije = await _oglasiServis.SviOglasiPotkategorije();
            //var oglasi = await _oglasiServis.SviOglasi();
            foreach (var kategorija in kategorije)
            {
                foreach (var potkategorija in potkategorije)
                {
                    if (kategorija.Id == potkategorija.KategorijeId)
                    {
                        kategorija.Potkategorije.Add(potkategorija);
                    }
                    foreach (var oglaspotkategorija in oglasipotkategorije)
                    {
                        if (potkategorija.Id == oglaspotkategorija.PotkategorijeId)
                        {
                            potkategorija.OglasiPotkagorije.Add(oglaspotkategorija);
                        }
                    }
                }

            }
            return View(kategorije);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
