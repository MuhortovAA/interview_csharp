using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_App.Interfaces
{
    public interface IPostmanService
    {
        void PickUpLetter(string postmanType);
        void DeliverLetter(string postmanType);
        void GetSignature(string postmanType);
        void HandOverLetter(string postmanType);
    }
}
