using JALOKA.Database;
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
        private readonly Connector db = new Connector();

        public void TabelPengembalian()
        {
            Tabel.CekTabel(db.Connection, "pengembalian");
        }
        public bool Pengembalian(int id_peminjaman)
        {
            var query = "UPDATE peminjamans SET Pengembalian = CURRENT_DATE WHERE pinjam_id = @id_peminjaman";
            using var cmd = new NpgsqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("id_peminjaman", id_peminjaman);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
