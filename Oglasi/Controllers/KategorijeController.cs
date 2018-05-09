using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oglasi.Models;
using Oglasi.Services;
using Oglasi.Data;
using Microsoft.EntityFrameworkCore;
namespace Oglasi.Controllers
{
    public class KategorijeController : Controller
    {
        private readonly IOglasiServis _oglasiServis;

        public KategorijeController(IOglasiServis oglasiServis)
        {
            _oglasiServis = oglasiServis;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Kategorija/Oglasi/id")]
        public async Task<IActionResult> Oglasi(int id)
        {
            
          
       //     ViewBag.Kategorije = await _oglasiServis.SveKategorije();
            ViewBag.Potkategorije =await _oglasiServis.SvePotkategorijeOdKategorije(id);
            return View();
        }

        public IActionResult Potkategorije()
        {
            return View();
        }
    }
}