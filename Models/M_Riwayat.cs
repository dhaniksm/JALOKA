
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    public class M_Riwayat
    {
        public int id_peminjaman { get; set; }
        public string judul { get; set; }
        public string nama { get; set; }
        public DateTime tanggal_pinjam { get; set; }
        public DateTime? tanggal_kembali { get; set; }
        public string status { get; set; }
    }
}
