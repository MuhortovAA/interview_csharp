using CodeFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext():base("DbConnection")
        {

        }
        public DbSet<Personal> Personals { get; set; }
    }
}
