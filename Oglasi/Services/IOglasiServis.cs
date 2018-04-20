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
    }
}
