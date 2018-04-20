using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class KategorijeProdavnice
    {
        public int Id { get; set; }

        public string NazivKategorije { get; set; }

        [InverseProperty("KategorijaProdavnice")]
        public ICollection<Prodavnice>  Prodavnice { get; set; }

        public KategorijeProdavnice()
        {
            this.Prodavnice = new HashSet<Prodavnice>();
        }
    }
}
