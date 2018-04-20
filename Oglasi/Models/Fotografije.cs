using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oglasi.Models
{
    public class Fotografije
    {
        public int Id { get; set; }

        public byte[] PodaciOSlici { get; set; }

        public int? OglasId { get; set; }

        public Oglasi Oglas { get; set; } 

        public int? ProizvodId { get; set; }

        public Proizvodi Proizvod { get; set; }
        
    }
}
