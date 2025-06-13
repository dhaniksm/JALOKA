using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Helpers
{
    public static class H_Pesan
    {
        public static void Sukses(string pesan, string judul = "Sukses")
        {
            MessageBox.Show(pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Gagal(string pesan, string judul = "Gagal")
        {
            MessageBox.Show(pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Peringatan(string pesan, string judul = "Peringatan")
        {
            MessageBox.Show(pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool Konfirmasi(string pesan)
        {
            DialogResult hasil = MessageBox.Show(pesan, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return hasil == DialogResult.Yes;
        }
    }
}
