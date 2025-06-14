namespace JALOKA.Models
{
    public class M_Peminjaman
    {
        public int id_peminjaman { get; set; }
        public int id_buku { get; set; }
        public string judul { get; set; }
        public DateTime tanggal_pinjam { get; set; }
        public DateTime? tanggal_kembali { get; set; }
        public string status { get; set; }
        public string nisn { get; set; }
    }
}
