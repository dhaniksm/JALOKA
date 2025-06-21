using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    public class M_Riwayat
    {
        public int IdPeminjaman { get; set; }
        public string Judul { get; set; }
        public string Nama { get; set; }
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public string Status { get; set; }
    }
}
