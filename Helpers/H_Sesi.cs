using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JALOKA.Helpers
{
    public static class H_Sesi
    {
        public static int nisn { get; private set; }
        public static string nama_lengkap { get; private set; }

        public static void SetSession(int id, string nama, string role)
        {
            nisn = id;
            nama_lengkap = nama;
        }

        public static void ClearSession()
        {
            nisn = 0;
            nama_lengkap = null;
        }

        public static bool IsLoggedIn()
        {
            return nisn > 0;
        }
    }
}