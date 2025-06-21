using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JALOKA.Helpers
{
    public static class H_Sesi
    {
        public static int IdUser { get; set; }
        public static string Nama{ get; set; }
        public static string IdAdmin { get; set; }
      
        public static void AturSesiP(int id_user, string nama_user)
        {
            IdUser = id_user;
            Nama = nama_user;
        }

        public static void AturSesiA(string id_pustakawan)
        {
            IdAdmin = id_pustakawan;
        }

        public static void AturSesiK(string id_kurikulum)
        {
            IdAdmin = id_kurikulum;
        }

        public static void HapusSesi()
        {
            IdUser = 0;
            IdAdmin = null;
            Nama = null;
        }

        public static bool LoggedP()
        {
            return IdUser > 0;
        }

        public static bool LoggedA()
        {
            return IdAdmin != null;
        }

    }
}
