namespace JALOKA.Models
{
    public class M_Peminjaman
    {
        public int IdPeminjaman { get; set; }
        public int IdUser { get; set; }
        public string NamaUser { get; set; }
        public int IdPustakawan { get; set; }
        public M_Buku Buku { get; set; }
        public int IdBuku { get; set; }
        public string JudulBuku { get; set; }
        public DateTime TanggalPinjam { get; set; }
        public DateTime TanggalKembali { get; set; }
        public DateTime TanggalDikembalikan { get; set; }
        public string Status { get; set; }
    }
}
