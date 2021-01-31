using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Profesor
    {
        public int Id { get; set; }
        [Display(Name ="Ime Profesora")]
        public string ImeProf { get; set; }
        [Display(Name ="Prezime Profesora")]
        public string PrezProf { get; set; }
        [Display(Name ="Broj telefona")]
        public int BrojTel { get; set; }
    }
}
