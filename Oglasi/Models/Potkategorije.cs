using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Potkategorije
    {
        public int Id { get; set; }

        public string NazivPotkategorije { get; set; }

        
        public int KategorijeId { get; set; }

        [ForeignKey("KategorijeId")]
        public Kategorije Kategorija { get; set; }

        [InverseProperty("Potkategorija")]
        public ICollection<OglasiPotkategorije> OglasiPotkagorije { get; set; }

        public Potkategorije()
        {
            this.OglasiPotkagorije = new HashSet<OglasiPotkategorije>();
        }
    }
}
