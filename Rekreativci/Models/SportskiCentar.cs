using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{

    public class SportskiCentar : IMapa
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 1, ErrorMessage = "Naziv centra ne bi trebao imati preko 100 znakova")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo koristenje velikih i malih slova, brojeva i razmaka!")]
        [DisplayName("Naziv sportskog centra:")]
        public string Naziv { get; set; }
        [Required]
        [DisplayName("Opis sportskog centra:")]
        public string Opis { get; set; } // nema drugih ogranicenja jer se moze pisati sta god 
        [NotMapped]
        [DisplayName("Slike")]
        public List<string> Slike { get; set; } // nije required jer ne mora imati slike
        [Required]
        [Range(0.0, 5.0, ErrorMessage = "Prosjecna ocjena mora biti od 0 do 5!")]
        [DisplayName("Prosjecna ocjena:")]
        public double ProsjecnaOcjena { get; set; }
        [Required]
        [DisplayName("Adresa sportskog centra:")]
        public string Adresa { get; set; }
        [Url]
        [DisplayName("Facebook stranica:")]
        public UrlAttribute FacebookUrl { get; set; } // nije Required jer ne mora svaki centar imati Facebook adresa

        [Url]
        [DisplayName("Web stranica:")]
        public UrlAttribute WebStranica { get; set; } // nije Required jer ne mora svaki centar imati web stranicu

        [Phone]
        [DisplayName("Kontakt telefon:")]
        public string BrojTelefona { get; set; } // nije Required jer ne mora ga imati svaki Sportski centar
        #endregion

        public SportskiCentar() { }

        public void PrikaziLokaciju(string adresa)
        {
            // TODO implementiraj
            throw new NotImplementedException();
        }
    }
}
