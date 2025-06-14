using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JALOKA.Database;
using JALOKA.Models;
using JALOKA.Controllers;
using Npgsql;



namespace JALOKA.Controllers
{
    class C_Kurikulum
    {
        private readonly D_Connector db = new D_Connector();

        public bool login(M_Kurikulum kurikulum)
        {
            if (string.IsNullOrWhiteSpace(kurikulum.id_kurikulum) || string.IsNullOrWhiteSpace(kurikulum.password))
                throw new ArgumentException("ID Kurikulum dan Password tidak boleh kosong.");
            try
            {
                var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM kurikulum WHERE id_kurikulum = @id_kurikulum AND password = @password", db.Connection);
                cmd.Parameters.AddWithValue("@id_kurikulum", kurikulum.id_kurikulum);
                cmd.Parameters.AddWithValue("@password", kurikulum.password);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal melakukan login: " + ex.Message);
            }
        }
    }
}
