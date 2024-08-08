using CrudProject.Data;
using CrudProject.Models;

namespace CrudProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            /* insert data into product table
             Product product = new Product(){Name="Tv", Price=2000 };
             Product product1 = new Product() { Name = "phone", Price = 2200 };
             Product product2 = new Product() { Name = "laptop", Price = 4000 };

             dbContext.Products.Add(product1);
             dbContext.Products.Add(product2);
             dbContext.SaveChanges();
             */
            /* insert data into order table 
            Order order = new Order() { Address = "Nablus" };
            Order order1 = new Order() { Address = "Hebron" };
            Order order2 = new Order() { Address = "Jerusalem" };

            dbContext.Orders.Add(order);
            dbContext.Orders.Add(order1);
            dbContext.Orders.Add(order2);
            dbContext.SaveChanges();
             
             */
            /*
             get all products:
             var products = dbContext.Products.ToList();
            foreach(var product in products)
            {
                Console.WriteLine(product.Name);
            }
             */



            /* get all orders:
          var orders = dbContext.Orders.ToList();
          foreach(var order in orders)
          {
              Console.WriteLine(order.Address);
          }
           
           
             */

            /* update product table:
             var product = dbContext.Products.First(pro => pro.Id == 1);
            product.Price = 5000;
            product.Name = "watch";
            dbContext.SaveChanges();
             */

            /*update order table
             var order = dbContext.Orders.First(o => o.Id == 3);
            order.Address = "Nablus";
            dbContext.SaveChanges();


             */

            /*remove product with id 2:
             var product = dbContext.Products.First(pro => pro.Id == 2);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();

             */


            /* remove order with id 3:
             
            var order = dbContext.Orders.First(o => o.Id == 3);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
             */









        }
    }
}
