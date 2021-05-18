using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rekreativci.Models
{
    public abstract class KorisnikSistema
    {
        #region Properties
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Ime korisnika:")]
        public string Ime { get; set; }
        [Required]
        [DisplayName("Prezime korisnika:")]
        public string Prezime { get; set; }
        [Required]
        [RegularExpression(@"[0-9|a-z|A-Z|.|_]*", ErrorMessage = "Dozvoljeno je samo korištenje brojeva, posebnih znakova, velikih i malih slova!")]
        [DisplayName("Korisnicko ime:")]
        public string KorisnickoIme { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 7, ErrorMessage = "Vaš password bi trebao imati najmanje 7 znakova!")]
        [DisplayName("Password:")]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        [DisplayName("Email:")]
        public string Email { get; set; }
        #endregion
        
        // treba za sada da ima i prazan konstruktor
        public KorisnikSistema() { }
       
    }
}
