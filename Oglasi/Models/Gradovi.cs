using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Gradovi
    {
        public int Id { get; set; }

        public string ImeGrada { get; set; }

        [InverseProperty("Grad")]
        public ICollection<Oglasi>Oglasi {get; set;}

        public Gradovi()
        {
            this.Oglasi = new HashSet<Oglasi>();
        }
    }
}
