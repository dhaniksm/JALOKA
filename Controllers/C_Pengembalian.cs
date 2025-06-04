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
        public bool Pengembalian(int pinjam_id)
        {
            var query = "UPDATE peminjamans SET Pengembalian = CURRENT_DATE WHERE pinjam_id = @pinjam_id";
            using var cmd = new NpgsqlCommand(query, db.Connection);
            cmd.Parameters.AddWithValue("pinjam_id", pinjam_id);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
