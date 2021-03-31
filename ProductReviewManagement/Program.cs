using System;
using System.Collections.Generic;
using System.Linq;
namespace ProductReviewManagement
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World 01!");

            List<Product_Review> list = new List<Product_Review>();

            list.Add(new Product_Review(1, 100, 4, "Good", true));
            list.Add(new Product_Review(2, 101, 4, "Good", true)); 
            list.Add(new Product_Review(3, 102, 3, "Good", true)); 
            list.Add(new Product_Review(4, 103, 5, "Amazing", true));
            list.Add(new Product_Review(5, 100, 1, "Worst", false));
            list.Add(new Product_Review(6, 105, 4, "Good", true));
            list.Add(new Product_Review(7, 106, 2, "Avg", false));
            list.Add(new Product_Review(8, 102, 3, "Avg", false));
            list.Add(new Product_Review(9, 108, 3, "Nice", false));
            list.Add(new Product_Review(10, 104, 5, "Good", true));
            list.Add(new Product_Review(11, 101, 4, "Good", true));
            list.Add(new Product_Review(12, 106, 3, "Good", true));
            list.Add(new Product_Review(3, 101, 1, "Bad", false));
            list.Add(new Product_Review(11, 106, 4, "Good", true));
            list.Add(new Product_Review(10, 101, 1, "Bad", false));

            //  displayList(list);

            Management management = new Management();
            //List<Product_Review> TopRatedList = management.GetTopThreeRatedProducts(list);
            //  displayList(TopRatedList);

            //List<Product_Review> RatingGreaterThanThree = management.GetRatedMoreThan3AndProductId1Or4Or9(list);
            // displayList(RatingGreaterThanThree);

            //  management.GetCountGroupProductId(list);



            // management.productIdAndReview(list);


            //  List<Product_Review> skippedRecords=management.skipTopFiveRecords(list);
            //  displayList(skippedRecords);

            // DataTableManagement dataTable = new DataTableManagement();
            // dataTable.displayDataTable();
            //  dataTable.displayIsAlikeTrue();

            // management.AvgRatingGroupByProductId(list);

            //  List<Product_Review> RiviewMessageGood = management.ReviewMessageNice(list);
            //   displayList(RiviewMessageGood);

            //    List<Product_Review> UserRecords = management.GetTheRecordsOfUserOrderByRating(list);
            //   displayList(UserRecords);
           // management.AvgRatingGroupByProductId(list);
           List<Product_Review> likedProductList= management.LikedProducts(list);

            displayList(likedProductList);
        }



        public static void displayList(List<Product_Review> list)
        {
            foreach (var r in list)
            {
                Console.WriteLine(r.productId + " " + r.userId + " " + r.rating + " " + r.review + " " + r.isLike);
            }
        }


        
    }
}
