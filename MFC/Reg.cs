using Microsoft.Win32;
using System.Data.SqlClient;
using Crypt;

namespace MFC
{
    class Reg
    {


        public static string DS;
        public static string IC;
        public static string UN;
        public static string UP;
        public SqlConnection Connection = new SqlConnection("Data Source = Empty; Initial Catalog = Empty; " +
        "Persist Security Info = True; User ID = Empty; Password = \"Empty\"");



        public void Register_get()
        {
            try
            {
                RegistryKey Sale_Option = Registry.CurrentUser;
                RegistryKey DBCon = Sale_Option.CreateSubKey("DB");
                DS = Crypt_Class.Decrypt(DBCon.GetValue("DS").ToString());
                IC = Crypt_Class.Decrypt(DBCon.GetValue("IC").ToString());
                UN = Crypt_Class.Decrypt(DBCon.GetValue("UN").ToString());
                UP = Crypt_Class.Decrypt(DBCon.GetValue("UP").ToString());
                Set_Connection();
            }
            catch
            {
                RegistryKey Sale_Option = Registry.CurrentUser;
                RegistryKey DBCon = Sale_Option.CreateSubKey("DB");
                DBCon.SetValue("DS", "Empty");
                DBCon.SetValue("IC", "Empty");
                DBCon.SetValue("UN", "Empty");
                DBCon.SetValue("UP", "Empty");
            }
        }

        public void Register_set(string DSvalue, string ICvalue, string UNvalue, string UPvalue)
        {
            RegistryKey Sale_Option = Registry.CurrentUser;
            RegistryKey DBCon = Sale_Option.CreateSubKey("DB");
            DBCon.SetValue("DS", Crypt_Class.Encrypt(DSvalue));
            DBCon.SetValue("IC", Crypt_Class.Encrypt(ICvalue));
            DBCon.SetValue("UN", Crypt_Class.Encrypt(UNvalue));
            DBCon.SetValue("UP", Crypt_Class.Encrypt(UPvalue));
            Register_get();
        }

        public void Set_Connection()
        {
            Connection.ConnectionString = "Data Source = " + DS + "; Initial Catalog = " + IC + "; Persist Security Info=True;" +
            " User ID = " + UN + ";Password=\"" + UP + "\"";
        }
    }
}
