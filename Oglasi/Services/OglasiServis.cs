using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oglasi.Models;
using Oglasi.Data;
using Microsoft.EntityFrameworkCore;
namespace Oglasi.Services
{
    public class OglasiServis : IOglasiServis
    {
        private readonly ApplicationDbContext _context;
        
        public OglasiServis(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Kategorije>> SveKategorije()
        {
            var kategorije =  await _context.Kategorije.ToArrayAsync();
            return kategorije;
        }

        public async Task<IEnumerable<Potkategorije>> SvePotkategorije()
        {
            var potkategorije = await _context.Potkategorije.Include(x=>x.Kategorija).ToArrayAsync();
            return potkategorije;
        }

        public async Task<IEnumerable<OglasiPotkategorije>> SviOglasiPotkategorije()
        {
            var oglasipotkategorije = await _context.OglasiPotkategorije.Include(x=>x.Oglas).Include(x=>x.Oglas.Grad).
                Include(x=>x.Potkategorija).ToArrayAsync();
            return oglasipotkategorije;
        }

        public async Task<IEnumerable<Models.Oglasi>> SviOglasi()
        {
            var oglasi = await _context.Oglasi.Include(x=>x.Grad).ToArrayAsync();
            return oglasi;
        }
    }
}
