using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oglasi.Models;
using Oglasi.Services;

namespace Oglasi.Controllers
{
    public class OglasiController : Controller
    {
        private readonly IOglasiServis _oglasiServis;

        public OglasiController(IOglasiServis oglasiServis)
        {
            _oglasiServis = oglasiServis;
        }

        public async Task<IActionResult> Index()
        {
            
            var oglasi = await _oglasiServis.SviOglasi();
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            return View(oglasi);
        }

        public async Task<IActionResult> Kategorija(int id)
        {
            var oglasi = await _oglasiServis.SviOglasiOdKategorije(id);
            var kategorija =  _oglasiServis.IzaberiKategoriju(id);
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.KategorijaId = id;
            ViewBag.KategorijaIme = kategorija.NazivKategorije;
            ViewBag.Potkategorije = await _oglasiServis.SvePotkategorijeOdKategorije(id);
            return View(oglasi);
        }

        public async Task<IActionResult> Potkategorija(int id)
        {
            var oglasi = await _oglasiServis.SviOglasiOdPotkategorije(id);           
            var potkategorija = _oglasiServis.IzaberiPotkategoriju(id);          
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.PotkategorijaId = id;
            ViewBag.KategorijaId = potkategorija.Kategorija.Id;
            ViewBag.PotkategorijaIme = potkategorija.NazivPotkategorije;
            ViewBag.Potkategorije = await _oglasiServis.SvePotkategorijeOdKategorije(potkategorija.Kategorija.Id);
            return View(oglasi);
        }

        public async Task<IActionResult> Grad(int id)
        {
            var oglasi = await _oglasiServis.SviOglasiIzGrada(id);
            var grad = _oglasiServis.IzaberiGrad(id);
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.ImeGrada = grad.ImeGrada;
            return View(oglasi);
        }


    }
}