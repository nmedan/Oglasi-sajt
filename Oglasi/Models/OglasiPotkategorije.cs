using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class OglasiPotkategorije
    {
        [Key, Column(Order = 0)]
        public int OglasiId { get; set; }

        [ForeignKey("OglasiId")]
        public Oglasi Oglas { get; set; }

        [Key, Column(Order = 1)]
        public int PotkategorijeId { get; set; }

        [ForeignKey("PotkategorijeId")]
        public Potkategorije Potkategorija { get; set; }
    }
}
