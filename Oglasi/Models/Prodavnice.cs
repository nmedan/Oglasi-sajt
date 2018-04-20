using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Prodavnice
    {
        public int Id { get; set; }

        public string NazivProdavnice { get; set; }

        public int KategorijeProdavniceId { get; set; }

        public KategorijeProdavnice KategorijaProdavnice { get; set; }

        [InverseProperty("Prodavnica")]
        public ICollection<Proizvodi> Proizvodi { get; set; }

        public Prodavnice()
        {
            this.Proizvodi = new HashSet<Proizvodi>();
        }
    }
}
