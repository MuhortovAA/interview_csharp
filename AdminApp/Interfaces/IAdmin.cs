using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp.Interfaces
{
    public interface IAdmin
    {
        void Authorization(string login, string password);
    }
}
