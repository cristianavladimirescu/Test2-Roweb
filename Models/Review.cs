using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        
        public string Name { get; set; }
        [Display(Name = "Review")]
        public string WrittenReview { get; set; }

        [Display(Name = "Review Date"), DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }


    }
}
