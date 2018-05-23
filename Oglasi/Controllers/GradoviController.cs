using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oglasi.Models;
using Oglasi.Services;

namespace Oglasi.Controllers
{
    public class GradoviController : Controller
    {
        private readonly IOglasiServis _oglasiServis;

        public GradoviController(IOglasiServis oglasiServis)
        {
            _oglasiServis = oglasiServis;
        }

        public async Task<IActionResult> Index()
        {
            var gradovi = await _oglasiServis.SviGradovi();
            var oglasi = await _oglasiServis.SviOglasi();
            var kategorije = await _oglasiServis.SveKategorije();
            foreach (var grad in gradovi)
            {
                foreach (var oglas in oglasi)
                {
                    if (oglas.Grad.Id == grad.Id)
                    {
                        grad.Oglasi.Add(oglas);
                    }
                }
            }
            ViewBag.Kategorije = kategorije;
            return View(gradovi);
        }
    }
}