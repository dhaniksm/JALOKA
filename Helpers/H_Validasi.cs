using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Helpers
{
    public static class H_Validasi
    {
        public static bool CekKosong(params TextBox[] teks)
        {
            foreach (var t in teks)
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    H_Pesan.Gagal("Data tidak boleh kosong: " + t.Name);
                    t.Focus();
                    return true;
                }
            }
            return false;
        }

        public static bool CekNumeric(TextBox teks)
        {
            if (!int.TryParse(teks.Text, out _))
            {
                H_Pesan.Gagal("Data harus berupa angka: " + teks.Name);
                teks.Focus();
                return false;
            }
            return true;
        }
    }
}
