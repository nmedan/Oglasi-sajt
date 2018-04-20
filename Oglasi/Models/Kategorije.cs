using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Kategorije
    {
        public int Id { get; set; }

        public string NazivKategorije { get; set; }

        [InverseProperty("Kategorija")]
        public ICollection<Potkategorije> Potkategorije {get; set; }

        public Kategorije()
        {
            this.Potkategorije = new HashSet<Potkategorije>();
        }
    }
}
