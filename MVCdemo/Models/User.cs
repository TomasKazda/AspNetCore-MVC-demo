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

            public int NoOfKids { get; set; }

            [Display(Name = "Datum narození")]
            public DateTime BirthDate { get; set; }

            public int Age
            {
                get
                {
                if (BirthDate == default) return 0;
                    return new DateTime(DateTime.Now.Subtract(BirthDate).Ticks).Year - 1;
                }
            }   
    }
}
