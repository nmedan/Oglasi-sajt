using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Poruke
    {
        public int Id { get; set; }

        public string Naslov { get; set; }

        [Required]
        public string TekstPoruke { get; set; }

        public string PrimalacId { get; set; }

        public string PosiljalacId { get; set; }

        [ForeignKey("PrimalacId")]
        public ApplicationUser Primalac { get; set; }

        [ForeignKey("PosiljalacId")]
        public ApplicationUser Posiljalac { get; set; }
    }
}
