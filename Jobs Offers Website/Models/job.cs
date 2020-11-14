using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jobs_Offers_Website.Models
{
    public class job
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [Display(Name = " Job Content")]
        public string JobContent { get; set; }

        [Display(Name = "Job Img")]
        public string JobImg { get; set; }

        [Display(Name = "Category Id")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}