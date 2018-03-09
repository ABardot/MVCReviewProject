using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewProject.Models
{
    public class Review
    {
        [Key]
        public int GameID { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public string GameReview { get; set; }
        public int GameScore { get; set; }
        public double Price { get; set; }


        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}