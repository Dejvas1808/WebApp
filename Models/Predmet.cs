using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Predmet
    {
        public int Id { get; set; }
        [Display(Name ="Naziv Predmeta")]
        public string NazivPred { get; set; }
        [Required]
        public int ECTS { get; set; }

    }
}
