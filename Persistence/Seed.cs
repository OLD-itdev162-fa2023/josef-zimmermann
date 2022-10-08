using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                  new Post {
                    Title = "First post",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Date = DateTime.Now.AddDays(-10)
                  }, 
                  new Post {
                    Title = "Second post",
                    Body = "Vestibulum tincidunt lectus justo. Sed risus neque, semper eget porttitor eu, maximus non turpis. Vivamus in consectetur leo. Praesent sit amet vehicula neque, venenatis hendrerit lorem. Cras scelerisque aliquet nunc eu ornare. Maecenas elementum hendrerit tellus, quis dapibus mi vestibulum vel. Aliquam imperdiet faucibus sem eu ullamcorper. Nunc vehicula sem erat, at commodo arcu rutrum quis. Duis nisl magna, congue finibus condimentum vel, facilisis quis metus. Vestibulum sodales sem eget faucibus pretium. Donec in mauris consectetur, sodales urna ut, pellentesque arcu. Sed dictum purus convallis vestibulum hendrerit. Quisque sed fringilla nibh. Suspendisse tempus ipsum sed vestibulum porta. Nunc tempor condimentum sapien, at interdum sapien molestie lobortis. Sed quis congue sem.",
                    Date = DateTime.Now.AddDays(-7)
                  }, 
                  new Post {
                    Title = "Third post",
                    Body = "Integer condimentum libero lobortis felis vehicula posuere. Donec risus nisl, finibus a ex quis, dapibus commodo libero. Sed ut elit quis nulla hendrerit imperdiet sed vitae augue. Sed eu eros id dui eleifend ornare. Nullam accumsan metus justo, ac aliquam urna pellentesque in. Interdum et malesuada fames ac ante ipsum primis in faucibus. Integer ac augue pulvinar, consectetur lacus ac, elementum neque. Maecenas viverra blandit ante, sed elementum tortor elementum at. Quisque at metus sed est semper ornare eu sit amet nibh. Sed vestibulum sodales dolor ut pulvinar. Proin pharetra nulla ligula, quis ultricies nibh placerat id. Mauris porta sagittis dolor eu feugiat. Aliquam luctus dapibus nisl vel cursus.",
                    Date = DateTime.Now.AddDays(-4)
                  }  
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}