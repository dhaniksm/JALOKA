using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JALOKA.Helpers
{
    public static class H_Sesi
    {
        public static int id { get; set; }
        public static string nama{ get; set; }
      
        public static void AturSesiP(int id_user, string nama_user)
        {
            id = id_user;
            nama = nama_user;
        }

        public static void AturSesiA(int id_pustakawan)
        {
            id = id_pustakawan;
        }

        public static void AturSesiK(int id_kurikulum)
        {
            id = id_kurikulum;
        }

        public static void HapusSesi()
        {
            id = 0;
            nama = null;
        }

        public static bool LoggedIn()
        {
            return id > 0;
        }
    }
}
