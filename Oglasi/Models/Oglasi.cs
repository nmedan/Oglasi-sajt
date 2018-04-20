using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Oglasi.Models
{
    public class Oglasi
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ovo polje se mora popuniti")]
        public string Naslov { get; set; }

        [Required(ErrorMessage = "Ovo polje se mora popuniti.")]
        public string TekstOglasa { get; set; }

        public int VrstaOglasa { get; set; }       

        public int BrojPregleda { get; set; }

        public bool Objavljen { get; set; }

        public int Obnoviti { get; set; }

        public int Cena { get; set; }

        public DateTime DatumObjave { get; set; }

        public DateTime DatumIsteka { get; set; }

        public string OsobaZaKontakt { get; set; }

        public string Telefon { get; set; }

        [Required(ErrorMessage ="Morate izabrati grad")]
        public int GradoviId { get; set; }

        [ForeignKey("GradoviId")]
        public Gradovi Grad { get; set; }

        public string AutorId { get; set; }

        [ForeignKey("AutorId")]
        public ApplicationUser Autor { get; set; }

        [InverseProperty("Oglas")]
        public ICollection<Fotografije> Fotografije { get; set; }

        [InverseProperty("Oglas")]
        public ICollection<OglasiPotkategorije> OglasiPotkategorije { get; set; }

        public Oglasi()
        {
            this.Fotografije = new HashSet<Fotografije>();
            this.OglasiPotkategorije = new HashSet<OglasiPotkategorije>();
        }
    }
}
