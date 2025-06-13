using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using JALOKA.Database;
using JALOKA.Models;

namespace JALOKA.Controllers
{
    public class C_Admin
    {
        private readonly Connector db = new Connector();

        public bool Login(M_Admin admin)
        {
            if (string.IsNullOrWhiteSpace(admin.id_pustakawan) || string.IsNullOrWhiteSpace(admin.password))
                throw new ArgumentException("ID dan Password tidak boleh kosong.");

            try
            {
                if (db.Connection.State != System.Data.ConnectionState.Open)
                    db.Connection.Open();

                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM admin WHERE id_pustakawan = @id AND password = @pw", db.Connection);
                cmd.Parameters.AddWithValue("@id", admin.id_pustakawan);
                cmd.Parameters.AddWithValue("@pw", admin.password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Login gagal: " + ex.Message);
            }
        }
    }
}

