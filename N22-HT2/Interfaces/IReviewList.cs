using N22_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_HT2.Interfaces
{
    internal interface IReviewList<TReview> where TReview : IReview
    {
        public void Add(TReview review);
        public void Update (int id, int star, string massage);
        public void Remove(int id);
        public void Remove(TReview review);
        public IReview GetReview(int id);
        public IReview GetReview(string massage);
        public string GetOverallReview();

    }
}
