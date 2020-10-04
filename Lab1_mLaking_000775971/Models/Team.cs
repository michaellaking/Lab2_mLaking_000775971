using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_mLaking_000775971.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required, Display(Name = "Email Address")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Display(Name = "EstablishedDate")]
        public DateTime? EstablishedDate { get; set; }


        
    }
}
