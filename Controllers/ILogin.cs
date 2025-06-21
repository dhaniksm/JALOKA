using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Controllers
{
    public interface ILogin
    {
        bool Login(string id, string password);
    }
}

