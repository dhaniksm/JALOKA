using JALOKA.Database;
using JALOKA.Helpers;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Controllers
{
    class C_Pengembalian
    {
        public void TabelPengembalian()
        {
            using var db = new D_Connector();
            D_Tabel.CekTabel(db.Connection, "pengembalian");
        }
        public void Pengembalian(int id_peminjaman)
        {
            try
            {
                using var db = new D_Connector();
                using var cmd = new NpgsqlCommand("UPDATE peminjamans SET Pengembalian = CURRENT_DATE WHERE pinjam_id = @id_peminjaman", db.Connection);
                cmd.Parameters.AddWithValue("id_peminjaman", id_peminjaman);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                H_Pesan.Gagal("Gagal melakukan pengembalian: " + ex.Message);
            }
            
        }
    }
}
