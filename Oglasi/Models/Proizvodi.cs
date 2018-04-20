using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Proizvodi
    {
        public int Id { get; set; }

        public string Naziv { get; set; }

        public int Cena { get; set; }

        public string Opis { get; set; }

        public int ProdavniceId { get; set; }

        public Prodavnice Prodavnica { get; set; }

        [InverseProperty("Proizvod")]
        public ICollection<Fotografije> Fotografije { get; set; }

        public Proizvodi()
        {
            this.Fotografije = new HashSet<Fotografije>();
        }
    }
}
