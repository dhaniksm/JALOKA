using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JALOKA.Helpers
{
    public static class H_Sesi
    {
        public static int id_user { get; private set; }
        public static string nama_lengkap { get; private set; }
      
        public static void SetSession(int id, string nama)
        {
            id_user = id;
            nama_lengkap = nama;
        }

        public static void ClearSession()
        {
            id_user = 0;
            nama_lengkap = null;
        }

        public static bool LoggedIn()
        {
            return id_user > 0;
        }
    }
}
