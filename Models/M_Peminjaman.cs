namespace JALOKA.Models
{
    public class M_Peminjaman
    {
        public int id_peminjaman { get; set; }
        public int id_buku { get; set; }
        public DateTime tanggal_peminjaman { get; set; }
        public DateTime? tanggal_pengembalian { get; set; }
        public string nisn { get; set; }
    }
}
