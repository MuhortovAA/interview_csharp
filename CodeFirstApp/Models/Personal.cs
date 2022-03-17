using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Models
{
    public class Personal
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string FIO { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int IdOrder { get; set; }
        [MaxLength(200)]
        public string CustomerName { get; set; }
    }
}
