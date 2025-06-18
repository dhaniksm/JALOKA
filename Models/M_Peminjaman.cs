namespace JALOKA.Models
{
    public class M_Peminjaman
    {
        public M_Buku buku { get; set; }
        public int id_peminjaman { get; set; }
        public int id_akun { get; set; }
        public int id_buku { get; set; }
        public DateTime tanggal_pinjam { get; set; }
        public DateTime? tanggal_kembali { get; set; }
        public string status { get; set; }

        public string judul_buku { get; set; }
        public string penulis_buku { get; set; }
        public byte[] cover_buku { get; set; }
        public string nama_peminjam { get; set; }
    }
}
