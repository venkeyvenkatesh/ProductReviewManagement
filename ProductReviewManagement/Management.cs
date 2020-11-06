using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ProductReviewManagement
{
    public class Management
    {

       //UC2 GetTopThree Rated Records
        public List<Product_Review> GetTopThreeRatedProducts(List<Product_Review> productReview)
        {
            var result = (from product in productReview
                          orderby product.rating descending
                          select product).Take(3);

            return result.ToList();
        }


        //UC3 Get the product details whose rate is more than 3 and prodcut id is either 1 or 4 or 9
        public List<Product_Review> GetRatedMoreThan3AndProductId1Or4Or9(List<Product_Review> product_Review)
        {
            var result = (from product in product_Review
                          where product.rating > 3 && (product.productId == 1 || product.productId == 4 || product.productId == 9)
                          select product).ToList();

            return result;
        }


        //UC4 get the count group by product id
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


        //UC5 Retrieve only product id and review
        public void productIdAndReview(List<Product_Review> product_Review)
        {
            var result = product_Review.Select(x => new { productId = x.productId, review = x.review });

            foreach (var element in result)
            {
                Console.WriteLine(element.productId + " " + element.review);
            }

        }

      


       
    }
}

