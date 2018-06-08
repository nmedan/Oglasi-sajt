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
            
            ViewBag.Oglasi = await _oglasiServis.SviOglasi();
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            return View();
        }

        public async Task<IActionResult> Kategorija(int id)
        {         
            var kategorija =  _oglasiServis.IzaberiKategoriju(id);
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.KategorijaId = id;
            ViewBag.KategorijaIme = kategorija.NazivKategorije;
            ViewBag.Oglasi = await _oglasiServis.SviOglasiOdKategorije(id);
            ViewBag.Potkategorije = await _oglasiServis.SvePotkategorijeOdKategorije(id);
            return View();
        }

        public async Task<IActionResult> Potkategorija(int id)
        {
                       
            var potkategorija = _oglasiServis.IzaberiPotkategoriju(id);          
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.PotkategorijaId = id;
            ViewBag.KategorijaId = potkategorija.Kategorija.Id;
            ViewBag.PotkategorijaIme = potkategorija.NazivPotkategorije;
            ViewBag.Oglasi = await _oglasiServis.SviOglasiOdPotkategorije(id);
            ViewBag.Potkategorije = await _oglasiServis.SvePotkategorijeOdKategorije(potkategorija.Kategorija.Id);
            return View();
        }

        public async Task<IActionResult> Grad(int id)
        {
           
            var grad = _oglasiServis.IzaberiGrad(id);
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.Oglasi = await _oglasiServis.SviOglasiIzGrada(id);
            ViewBag.ImeGrada = grad.ImeGrada;
            return View();
        }

        
        public async Task <IActionResult> Pretraga(Pretraga pretraga)
        {
            ViewBag.Oglasi = await _oglasiServis.TraziOglase(pretraga.Tekst);
            ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            return View();
        }
    }
}