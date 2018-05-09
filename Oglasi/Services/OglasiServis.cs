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
            var kategorije = await _context.Kategorije.ToArrayAsync();
            return kategorije;
        }

        public async Task<IEnumerable<Potkategorije>> SvePotkategorije()
        {
            var potkategorije = await _context.Potkategorije.Include(x => x.Kategorija).ToArrayAsync();
            return potkategorije;
        }

        public async Task<IEnumerable<OglasiPotkategorije>> SviOglasiPotkategorije()
        {
            var oglasipotkategorije = await _context.OglasiPotkategorije.Include(x => x.Oglas).Include(x => x.Oglas.Grad).
                Include(x => x.Potkategorija).ToArrayAsync();
            return oglasipotkategorije;
        }

        public async Task<IEnumerable<Models.Oglasi>> SviOglasi()
        {
            var oglasi = await _context.Oglasi.Include(x => x.Grad).ToArrayAsync();
            return oglasi;
        }

        public async Task<IEnumerable<Models.Oglasi>> SviOglasiOdKategorije(int id)
        {
            List<Models.Oglasi> Ogl = new List<Models.Oglasi>();
            var oglasiPotkategorije = await _context.OglasiPotkategorije.Include(x => x.Oglas).Include(x => x.Potkategorija).
                Include(x => x.Potkategorija.Kategorija).Include(x => x.Oglas.Grad).Where(x => x.Potkategorija.KategorijeId == id).
                ToArrayAsync();
            var potkategorije = SvePotkategorijeOdKategorije(id);
            foreach (var op in oglasiPotkategorije)
            {

                var ogl = _context.Oglasi.Find(op.OglasiId);
                Ogl.Add(ogl);

            }

            return Ogl.ToAsyncEnumerable().ToEnumerable();
        }

        public async Task<IEnumerable<Models.Oglasi>> SviOglasiOdPotkategorije(int id)
        {
            List<Models.Oglasi> Ogl = new List<Models.Oglasi>();
            var oglasiPotkategorije = await _context.OglasiPotkategorije.Include(x => x.Oglas).Include(x => x.Potkategorija).
                Include(x => x.Potkategorija.Kategorija).Include(x => x.Oglas.Grad).Where(x => x.Potkategorija.Id == id).
                ToArrayAsync();
            foreach (var op in oglasiPotkategorije)
            {
                Ogl.Add(op.Oglas);
            }
            return Ogl.ToAsyncEnumerable().ToEnumerable();
        }

        public async Task<IEnumerable<Potkategorije>> SvePotkategorijeOdKategorije(int id)
        {
            var potkategorije = await  _context.Potkategorije.Include(x => x.Kategorija).Where(x => x.Kategorija.Id == id).
                ToArrayAsync();
            return potkategorije;
        }

        public Kategorije IzaberiKategoriju(int id)
        {
            var kategorija = _context.Kategorije.Find(id);
            return kategorija;
        }

        public Potkategorije IzaberiPotkategoriju(int id)
        {
            var potkategorija = _context.Potkategorije.Find(id);
            return potkategorija;
        }

        public Oglasi.Models.Oglasi IzaberiOglas(int id)
        {
            var oglas = _context.Oglasi.Find(id);
            return oglas;
        }
    }
}
