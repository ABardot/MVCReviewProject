﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCReviewProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name="Category")]
        public string Name { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}