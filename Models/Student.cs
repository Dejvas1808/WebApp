using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name ="Ime Studenta")]
        public string ImeStud { get; set; }
        [Display(Name ="Prezime Studenta")]
        public string PrezStud { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Datum Rođenja")]
        public DateTime DatRod { get; set; }
    }
}
