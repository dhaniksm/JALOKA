using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JALOKA.Helpers
{
    public static class H_Sesi
    {
        public static int IdUser { get; private set; }
        public static string Nama { get; private set; }

        public static string IdAdmin { get; private set; }
        public static string IdKurikulum { get; private set; }

        // Untuk pelajar
        public static void AturSesiP(int id_user, string nama_user)
        {
            IdUser = id_user;
            Nama = nama_user;
        }

        // Untuk admin
        public static void AturSesiA(string id_pustakawan)
        {
            IdAdmin = id_pustakawan;
        }

        // Untuk kurikulum
        public static void AturSesiK(string id_kurikulum)
        {
            IdKurikulum = id_kurikulum;
        }

        // Hapus semua sesi
        public static void HapusSesi()
        {
            IdUser = 0;
            Nama = null;
            IdAdmin = null;
            IdKurikulum = null;
        }

        // Cek login berdasarkan role
        public static bool LoggedP()
        {
            return IdUser > 0;
        }

        public static bool LoggedA()
        {
            return IdAdmin != null;
        }

        public static bool LoggedK()
        {
            return IdKurikulum != null;
        }
    }
}

