using AdminApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp.Repository
{
    public class UserRepository : IAdmin
    {
        private AdminEntities db;
        public UserRepository()
        {

        }

        public void Authorization(string login, string password)
        {
            using (db = new AdminEntities())
            {
                var result = db.LUserARM("admin22222", "11111111", "0000", 3, new ObjectParameter("ErrorCode", typeof(int))).ToList().FirstOrDefault();
            }
        }
    }
}
