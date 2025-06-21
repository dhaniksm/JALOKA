using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    public class M_Pengguna
    {
        public int IdUser { get; set; }
        public string Nisn { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string NomorHp { get; set; }
        public string Alamat { get; set; }
    }
}
