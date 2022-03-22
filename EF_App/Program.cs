using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext context = new UserContext())
            {

                var customer1 = new Customer()
                {
                    FirstName = "Петр",
                    LastName = "Сидоров",
                    Age = 28,
                    Email = "xbest@mail.ru"
                };
                context.Customers.Add(customer1);
                Order order = new Order
                {
                    ProductName = "Яблоки",
                    Quantity = 5,
                    PurchaseDate = DateTime.Now,
                    // Ссылка на покупателя в навигационном свойстве
                    Customer = customer1
                };

                context.Orders.Add(order);

                //context.SaveChanges();

                //// пересоздадим базу данных
                //SprDepartment spr1 = new SprDepartment { Name = "Personal" };
                //SprDepartment spr2 = new SprDepartment { Name = "Account" };



                //// создаем два объекта User
                //User user1 = new User { Name = "Tom", Age = 33 };
                //User user2 = new User { Name = "Sam", Age = 26 };

                ////
                //Departament dep1 = new Departament { SprDepartment = spr1, User = user1 };
                //Departament dep2 = new Departament { SprDepartment = spr2, User = user2 };



                //// добавляем их в бд
                //db.Users.Add(user1);
                //db.Users.Add(user2);
                //db.SprDepartment.Add(spr1);
                //db.SprDepartment.Add(spr2);
                //db.Departament.Add(dep1);
                //db.Departament.Add(dep2);
                ////db.SaveChanges();
                //Console.WriteLine("Объекты успешно сохранены");

                // Загрузить одного покупателя
                //Customer customer = context.Customers
                //    .Where(c => c.CustomerId == 2)
                //    .FirstOrDefault();

                //// Попытаться загрузить связанные с ним заказы
                //if (customer != null && customer.Orders != null)
                //    foreach (Order order in customer.Orders)
                //        Console.WriteLine(order.ProductName);



                //List<Customer> customers = context.Customers.Include(c => c.Orders).ToList();

                // Получить все их заказы
                //List<Order> orders = customers.SelectMany(c => c.Orders)
                //    // Запрос к базе данных не выполняется,
                //    // т.к. данные уже были извлечены 
                //    // ранее с помощью прямой загрузки
                //    .ToList();

                //// получаем объекты из бд и выводим на консоль
                //var customers = context.Customers;
                //Console.WriteLine("List objects:");
                //foreach (Customer c in customers)
                //{
                //    Console.WriteLine($"{c.CustomerId}.{c.FirstName} {c.LastName} {c.Age} {c.Email}");
                //}
            }
            Console.Read();
        }
    }
}
