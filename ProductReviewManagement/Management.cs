using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
namespace ProductReviewManagement
{
    public class Management
    {
        public List<Product_Review> GetTopThreeRatedProducts(List<Product_Review> productReview)
        {
            var result = (from product in productReview
                          orderby product.rating descending
                          select product).Take(3);

            return result.ToList();
        }
    }
}

