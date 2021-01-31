using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Polaganje
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        [Display(Name ="Ime Studenta")]
        public string ImeStudenta { get; set; }
        public Profesor Profesor { get; set; }
        [Display(Name ="Ime Profesora")]
        public string ImeProfesora { get; set; }
        public Predmet Predmet { get; set; }
        [Display(Name ="Naziv Predmeta")]
        public string Naziv { get; set; }

        [MaxLength(2)]
        [Display(Name ="Položio/la")]
        public string Polozio { get; set; }
    }
}
