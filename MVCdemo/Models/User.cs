using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCdemo.Models
{
        public class User
        {
            [Required(ErrorMessage = "Jméno musí být vyplněno.")]
            [Display(Name = "Jméno")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "Příjmení musí být vyplněno.")]
            [Display(Name = "Příjmení")]
            public string LastName { get; set; }

            [Display(Name = "Datum narození")]
            public DateTime DateTime { get; set; }
        }
}
