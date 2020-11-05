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

        public List<Product_Review> GetRatedMoreThan3AndProductId1Or4Or9(List<Product_Review> product_Review)
        {
            var result = (from product in product_Review
                          where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9)
                          select product).ToList();

            return result;
        }


        public void GetCountGroupProductId(List<Product_Review> productReview)
        {


            var result = productReview.GroupBy(x => x.productId)
                         .Select(x => new { productId = x.Key, count = x.Count() });
            Console.WriteLine("productId" + "\t " + "NoOfReviews");
            foreach (var x in result)
            {
                Console.WriteLine("   " + x.productId + "\t\t    " + x.count);
            }
        }
    }
}

