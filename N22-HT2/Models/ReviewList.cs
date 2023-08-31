using N22_HT2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2.Models
{
    internal class ReviewList<TReview> : IReviewList<TReview> where TReview : IReview
    {
        private List<TReview> _reviews = new();

        public void Add(TReview review)
        {
            _reviews.Add(review);
        }

        public string GetOverallReview()
        {
            if (_reviews.Count == 0) return "Be the first to leave a review for this product";
            var result = _reviews.All(review => review.Star == 5);
            if (result) return "Great news! All reviews for this product are 5-star ratings.";
            var oneStar = _reviews.FirstOrDefault(review => review.Star == 1);
            if (oneStar != null) return $"{oneStar.Massage}";
            return "";
        }

        public IReview GetReview(int id)
        {
            var getReview = _reviews.FirstOrDefault(review => review.Id == id);
            return getReview;
       
        }

        public IReview GetReview(string massage)
        {
            var getReview = _reviews.FirstOrDefault(review => review.Massage == massage);
            return getReview;
        }

        public void Remove(int id)
        {
            var delete = _reviews.FirstOrDefault(review => review.Id == id);
            if (delete != null) _reviews.Remove(delete);
            else Console.WriteLine("Bunday id-li review topilmadi!");
        }

        public void Remove(TReview review)
        {
            var delete = _reviews.FirstOrDefault(item => item.Id == review.Id);
            if (delete != null) _reviews.Remove(delete);
            else Console.WriteLine("Bunday review topilmadi!");
        }

        public void Update(int id, int star, string massage)
        {
            var result = _reviews.FirstOrDefault(item => item.Id == id);
            if (result != null)
            {
                result.Star = star;
                result.Massage = massage;
            }
            else Console.WriteLine("Bunday id-li review topilmadi!");
        }
    }
}
