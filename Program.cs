
using CRUD.Data;
using CRUD.Models;
using System.Runtime.Intrinsics.Arm;

namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDDbContext db = new CRUDDbContext();
            //Order order=new Order() 
            //{ 
            //    Address="Yata",
            //    CreatedAt=DateTime.Now,
            //};
            //Product product = new Product()
            //{
            //    Name="C",
            //    Price=3000
            //};
            //db.products.Add(product);
            //db.orders.Add(order);
            //db.SaveChanges();
            //var updateProduct = db.products.First(p => p.Id == 3);
            //updateProduct.Name = "L";
            //var updateOrder = db.orders.First(p => p.Id == 1);
            //updateOrder.CreatedAt = DateTime.Now;
            //db.SaveChanges();
            var removeProduct=db.products.First(p=>p.Id==2);
            var removeOrder=db.orders.First(p=>p.Id==3);
            db.products.Remove(removeProduct);
            db.orders.Remove(removeOrder);
            db.SaveChanges();
            var getProduct=db.products.ToList();
            var getOrder=db.orders.ToList();
            foreach (var item in getProduct)
            {
                Console.WriteLine($"Name is : {item.Name} ... Price is : {item.Price}");
            }
            Console.WriteLine("--------------------");
            foreach (var item in getOrder)
            {
                Console.WriteLine($"Address is : {item.Address} ... Create is : {item.CreatedAt}");
            }

        }
    }
}
