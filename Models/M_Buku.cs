using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    public class M_Buku
    {
        public int id_buku { get; set; }
        public string judul { get; set; }
        public string penulis { get; set; }
        public int tahun_terbit { get; set; }
        public int stok { get; set; }
        public string cover_path { get; set; }
    }
}

