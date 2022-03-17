using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_App
{

    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        [Column(TypeName = "Image")]
        public byte[] Photo { get; set; }

        // Ссылка на заказы
        public virtual List<Order> Orders { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }

        // Ссылка на покупателя
        public Customer Customer { get; set; }
    }


    //public class User
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    //public Departament Departament { get; set; } = new Departament();
    //}

    //public class SprDepartment
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    //public Departament Departament { get; set; } = new Departament();
    //}
    //public class Departament
    //{
    //    public int Id { get; set; }
    //    public User User { get; set; } = new User();
    //    public SprDepartment SprDepartment { get; set; } = new SprDepartment();
    //    //public int IdDepartament { get; set; }
    //    //public List<Departament> Departament { get; set; } = new List<Departament>();
    //    //public List<SprDepartment> SprDepartment { get; set; } = new List<SprDepartment>();
    //}
}
