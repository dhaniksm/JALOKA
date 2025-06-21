using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    public class M_Buku
    {
        public int IdBuku { get; set; }
        public string Judul { get; set; }
        public string Penulis { get; set; }
        public string Penerbit { get; set; }
        public int TahunTerbit { get; set; }
        public int Stok { get; set; }
        public string Sinopsis { get; set; }
        public byte[] Cover { get; set; }
    }
}

