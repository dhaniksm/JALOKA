
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Models
{
    class M_Riwayat
    {
        public int pinjam_id { get; set; }
        public int buku_id { get; set; }               // dari M_Peminjaman
        public string judul { get; set; }          // dari M_Buku
        public int id_user { get; set; }                // dari M_Peminjaman
        public string nama { get; set; }           // dari Users
        public DateTime tanggal_peminjaman { get; set; } // dari M_Peminjaman
        public DateTime? tanggal_pengembalian { get; set; }
    }
}
