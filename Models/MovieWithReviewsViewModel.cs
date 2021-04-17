using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieWithReviewsViewModel
    {
        public MovieWithReviewsViewModel(Movie movieItem, List<Review> reviewList)
        {
            MovieItem = movieItem;
            ReviewList = reviewList;
        }
        public Movie MovieItem { get; set; }
        public List<Review> ReviewList { get; set; }
    }
}
