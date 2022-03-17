using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_App
{
    class UserContext:DbContext
    {
        public UserContext():base("DbConnection")
        {
            // Указывает EF, что если модель изменилась,
            // нужно воссоздать базу данных с новой структурой
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<UserContext>());
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<SprDepartment> SprDepartment { get; set; }
        //public DbSet<Departament> Departament { get; set; }
    }
}
