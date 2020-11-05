using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
   public  class Product_Review
    {
        public int productId
        {
            get;
            set;
        }
        public int userId
        {
            get;
            set;
        }
        public int rating
        {
            get;
            set;
        }
        public string review
        {
            get;
            set;
        }
        public bool isLike
        {
            get;
            set;
        }


        public Product_Review(int productId, int userId, int rating, string review, bool isLike)
        {
            this.productId = productId;
            this.userId = userId;
            this.rating = rating;
            this.review = review;
            this.isLike = isLike;
        }
    }
}
