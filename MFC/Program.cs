using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Zastavka first = new Zastavka();
            DateTime end = DateTime.Now + TimeSpan.FromMilliseconds(5000);
            first.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            Application.Run(new ConnectToBD());
        }
        public static string FIOSOTR;
        public static bool ADMINACCESS;
        public static bool BACKTOADMIN;
        public static int USERID;
        public static int SYSACCESS;
        public static int PSACCESS;
        public static int AOACCESS;
        public static int ZAGZACCESS;
        public static int UOACCESS;
        public static int OFMSACCESS;
        public static int SZACCESS;
        public static int RG_PSA;
        public static int RG_AOA;
        public static int RG_UOA;
        public static int RG_OFMSA;
        public static int RG_ZAGSA;
        public static int RG_SZA;
        public static DataTable Role_Select;
        public static DataTable Sotr_Select;

    }
}
