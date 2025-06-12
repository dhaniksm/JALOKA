namespace JALOKA.Models
{
    public class M_Peminjaman
    {
        public int pinjam_id { get; set; }
        public int buku_id { get; set; }
        public DateTime tanggal_peminjaman { get; set; }
        public DateTime? tanggal_pengembalian { get; set; }
        public string nisn { get; set; }
    }
}
