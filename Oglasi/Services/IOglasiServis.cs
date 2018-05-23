using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oglasi.Models;
using Microsoft.EntityFrameworkCore;

namespace Oglasi.Services
{
    public interface IOglasiServis
    {
        Task<IEnumerable<Kategorije>> SveKategorije();
        Task<IEnumerable<Potkategorije>> SvePotkategorije();
        Task<IEnumerable<OglasiPotkategorije>> SviOglasiPotkategorije();
        Task<IEnumerable<Models.Oglasi>> SviOglasi();
        Task<IEnumerable<Models.Gradovi>> SviGradovi();
        Task<IEnumerable<Models.Oglasi>> SviOglasiOdKategorije(int id);
        Task<IEnumerable<Models.Oglasi>> SviOglasiOdPotkategorije(int id);
        Task<IEnumerable<Models.Oglasi>> SviOglasiIzGrada(int id);
        Task<IEnumerable<Models.Potkategorije>> SvePotkategorijeOdKategorije(int id);
        Gradovi IzaberiGrad(int id);
        Kategorije IzaberiKategoriju(int id);
        Potkategorije IzaberiPotkategoriju(int id);
        Oglasi.Models.Oglasi IzaberiOglas(int id);
    }
}
