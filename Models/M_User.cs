using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    public class M_User
    {
        public int id_user { get; set; }
        public string id_pelajar { get; set; }
        public string password { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string nomor_hp { get; set; }
        public string alamat { get; set; }
    }
}
