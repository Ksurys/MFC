﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MFC
{
    class ControlBD
    {
        public event Action<DataSet> List_Dbs;
        public event Action<DataTable> List_Server;
        private Reg _RI;
        public event Action<bool> Status;
        private SqlCommand _CmdSql;
        public string ps_access_value = "select [dbo].[Role].[Pasportni] from [dbo].[Role] where [Name_Role] = '";
        public string ao_access_value = "select [dbo].[Role].[Abonentski] from [dbo].[Role] where [Name_Role] = '";
        public string uo_access_value = "select [dbo].[Role].[Univerrsal] from [dbo].[Role] where [Name_Role] = '";
        public string sz_access_value = "select [dbo].[Role].[Soc_Zashch] from [dbo].[Role] where [Name_Role] = '";
        public string ofms_access_value = "select [dbo].[Role].[OFMS] from [dbo].[Role] where [Name_Role] = '";
        public string zags_access_value = "select [dbo].[Role].[ZAGS] from [dbo].[Role] where [Name_Role] = '";
        private string user_id = "select [dbo].[Sotr].[id_Sotr] from [dbo].[Sotr] where Login = '";
        private string user_fio = "select F_Sotr + ' ' + I_Sotr + ' ' + O_Sotr from [dbo].Sotr where id_Sotr = ";
        private string sy_access = "select System_Access from [dbo].[Sotr] where [dbo].[Sotr].[id_Sotr] = ";
        private string ps_access = "select [dbo].[Role].[Pasportni] from [dbo].[Role] " +
                                  "inner join [dbo].[Sotr] on [dbo].[Sotr].[Role_id] = [dbo]." +
                                  "[Role].[id_Role] where [Sotr].[id_Sotr] = ";
        private string ao_access = "select [dbo].[Role].[Abonentski] from [dbo].[Role] " +
                                  "inner join [dbo].[Sotr] on [dbo].[Sotr].[Role_id] = [dbo]." +
                                  "[Role].[id_Role] where [Sotr].[id_Sotr] = ";
        private string uo_access = "select [dbo].[Role].[Univerrsal] from [dbo].[Role] " +
                                  "inner join [dbo].[Sotr] on [dbo].[Sotr].[Role_id] = [dbo]." +
                                  "[Role].[id_Role] where [Sotr].[id_Sotr] = ";
        private string zags_access = "select [dbo].[Role].[ZAGS] from [dbo].[Role] " +
                                  "inner join [dbo].[Sotr] on [dbo].[Sotr].[Role_id] = [dbo]." +
                                  "[Role].[id_Role] where [Sotr].[id_Sotr] = ";
        private string ofms_access = "select [dbo].[Role].[OFMS] from [dbo].[Role] " +
                                  "inner join [dbo].[Sotr] on [dbo].[Sotr].[Role_id] = [dbo]." +
                                  "[Role].[id_Role] where [Sotr].[id_Sotr] = ";
        private string sz_access = "select [dbo].[Role].[Soc_Zashch] from [dbo].[Role] " +
                                  "inner join [dbo].[Sotr] on [dbo].[Sotr].[Role_id] = [dbo]." +
                                  "[Role].[id_Role] where [Sotr].[id_Sotr] = ";
        public void Get_Base_List()
        {
            _RI = new Reg();
            try
            {
                SqlConnection GDtBsLstCn = new SqlConnection("Data Source = " + Reg.DS + "; Initial Catalog = master; " +
                                                             "Persist Security Info=True; User ID = " + Reg.UN +
                                                             ";Password=\"" + Reg.UP + "\"");
                GDtBsLstCn.Open();
                SqlDataAdapter BsAdpt = new SqlDataAdapter("exec sp_helpdb", GDtBsLstCn);
                DataSet BDst = new DataSet();
                BsAdpt.Fill(BDst, "db");
                List_Dbs(BDst);
                _RI.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Get_Server_List()
        {
            SqlDataSourceEnumerator ServersCheck = SqlDataSourceEnumerator.Instance;
            DataTable ServersTable = ServersCheck.GetDataSources();
            List_Server(ServersTable);
        }

        public void Connection_State()
        {
            _RI = new Reg();
            _RI.Register_get();
            try
            {
                _RI.Connection.Open();
                Status(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Status(false);
            }
        }

        public void Autorization(string usr_id, string usr_pass)
        {
            try
            {
                _RI = new Reg();
                _RI.Set_Connection();
                _RI.Connection.Open();
                _CmdSql = new SqlCommand(user_id + usr_id + "' and Password = '" + usr_pass + "'", _RI.Connection);
                Program.USERID = Convert.ToInt32(_CmdSql.ExecuteScalar().ToString());
                _CmdSql = new SqlCommand(sy_access + Program.USERID, _RI.Connection);
                Program.SYSACCESS = Convert.ToInt32(_CmdSql.ExecuteScalar().ToString());
                SqlCommand PSACCESSCmd = new SqlCommand(ps_access + Program.USERID, _RI.Connection);
                SqlCommand AOACCESSCmd = new SqlCommand(ao_access + Program.USERID, _RI.Connection);
                SqlCommand UOACCESSCmd = new SqlCommand(uo_access + Program.USERID, _RI.Connection);
                SqlCommand ZAGZACCESSCmd = new SqlCommand(zags_access + Program.USERID, _RI.Connection);
                SqlCommand OFMSACCESSCmd = new SqlCommand(ofms_access + Program.USERID, _RI.Connection);
                SqlCommand SZACCESSCmd = new SqlCommand(sz_access + Program.USERID, _RI.Connection);
                SqlCommand FIOSOTRCmd = new SqlCommand(user_fio + Program.USERID, _RI.Connection);
                Program.FIOSOTR = FIOSOTRCmd.ExecuteScalar().ToString();
                Program.PSACCESS = Convert.ToInt32(PSACCESSCmd.ExecuteScalar().ToString());
                Program.AOACCESS = Convert.ToInt32(AOACCESSCmd.ExecuteScalar().ToString());
                Program.UOACCESS = Convert.ToInt32(UOACCESSCmd.ExecuteScalar().ToString());
                Program.ZAGZACCESS = Convert.ToInt32(ZAGZACCESSCmd.ExecuteScalar().ToString());
                Program.OFMSACCESS = Convert.ToInt32(OFMSACCESSCmd.ExecuteScalar().ToString());
                Program.SZACCESS = Convert.ToInt32(SZACCESSCmd.ExecuteScalar().ToString());
                _RI.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Sotr_add_void(string FV, string IV, string OV, string PV, string LV, string EMV, int RV, int SID)
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand StrPrc = new SqlCommand("Sotr_add", _RI.Connection);
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@f_Sotr", FV);
            StrPrc.Parameters.AddWithValue("@i_Sotr", IV);
            StrPrc.Parameters.AddWithValue("@o_Sotr", OV);
            StrPrc.Parameters.AddWithValue("@Password", PV);
            StrPrc.Parameters.AddWithValue("@Login", LV);
            StrPrc.Parameters.AddWithValue("@E_Mail", EMV);
            StrPrc.Parameters.AddWithValue("@System_Access", SID);
            StrPrc.Parameters.AddWithValue("@Role_id", RV);
            StrPrc.ExecuteNonQuery();
            _RI.Connection.Close();
        }

        public void Sotr_edit_void(int ID, string FV, string IV, string OV, string PV, string LV, string EMV, int RV, int SID)
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand StrPrc = new SqlCommand("Sotr_edit", _RI.Connection);
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@id_Sotr", ID);
            StrPrc.Parameters.AddWithValue("@f_Sotr", FV);
            StrPrc.Parameters.AddWithValue("@i_Sotr", IV);
            StrPrc.Parameters.AddWithValue("@o_Sotr", OV);
            StrPrc.Parameters.AddWithValue("@Password", PV);
            StrPrc.Parameters.AddWithValue("@Login", LV);
            StrPrc.Parameters.AddWithValue("@E_Mail", EMV);
            StrPrc.Parameters.AddWithValue("@System_Access", SID);
            StrPrc.Parameters.AddWithValue("@Role_id", RV);
            StrPrc.ExecuteNonQuery();
            _RI.Connection.Close();
        }

        public void Sotr_delete_void(int ID)
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand StrPrc = new SqlCommand("Sotr_delete", _RI.Connection);
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@id_Sotr", ID);
            StrPrc.ExecuteNonQuery();
            _RI.Connection.Close();
        }

        public void Role_add_void(string value, int AOID, int PSID, int UOID, int OFMSID, int ZAGSID, int SZID)
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand StrPrc = new SqlCommand("Role_add", _RI.Connection);
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@Name_Role", value);
            StrPrc.Parameters.AddWithValue("@Abonentski", AOID);
            StrPrc.Parameters.AddWithValue("@Pasportni", PSID);
            StrPrc.Parameters.AddWithValue("@Univerrsal", UOID);
            StrPrc.Parameters.AddWithValue("@OFMS", OFMSID);
            StrPrc.Parameters.AddWithValue("@ZAGS", ZAGSID);
            StrPrc.Parameters.AddWithValue("@Soc_Zashch", SZID);
            StrPrc.ExecuteNonQuery();
            _RI.Connection.Close();
        }

        public void Role_edit_void(int ID, string value, int AOID, int PSID, int UOID, int OFMSID, int ZAGSID, int SZID)
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand StrPrc = new SqlCommand("Role_edit", _RI.Connection);
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@id_Role", ID);
            StrPrc.Parameters.AddWithValue("@Name_Role", value);
            StrPrc.Parameters.AddWithValue("@Abonentski", AOID);
            StrPrc.Parameters.AddWithValue("@Pasportni", PSID);
            StrPrc.Parameters.AddWithValue("@Univerrsal", UOID);
            StrPrc.Parameters.AddWithValue("@OFMS", OFMSID);
            StrPrc.Parameters.AddWithValue("@ZAGS", ZAGSID);
            StrPrc.Parameters.AddWithValue("@Soc_Zashch", SZID);
            StrPrc.ExecuteNonQuery();
            _RI.Connection.Close();
        }

        public void Role_delete_void(int ID)
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand StrPrc = new SqlCommand("Role_delete", _RI.Connection);
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@id_Role", ID);
            StrPrc.ExecuteNonQuery();
            _RI.Connection.Close();
        }

        public void Role_Select_void()
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand Role_Select = new SqlCommand("select [id_Role], [Name_Role], [Pasportni], [Abonentski], [Univerrsal], [OFMS], [ZAGS], [Soc_Zashch]" +
                                                    "from [MFC].[dbo].[Role]", _RI.Connection);
            SqlDataReader tableReader = Role_Select.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(tableReader);
            Program.Role_Select = Table;
            _RI.Connection.Close();
        }

        public void Sotr_Select_void()
        {
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand Sotr_Select = new SqlCommand("select [id_Sotr], [f_Sotr], [i_Sotr], [o_Sotr], [Password], [Login], " +
                                                        "[E_mail], [System_Access], [Role_id] from [MFC].[dbo].[Sotr]", _RI.Connection);
            SqlDataReader tableReader = Sotr_Select.ExecuteReader();
            DataTable Table = new DataTable();
            Table.Load(tableReader);
            Program.Sotr_Select = Table;
            _RI.Connection.Close();
        }

        public void get_role_void(string value)
        {
            int ps, ao, uo, sz, of, za;
            _RI = new Reg();
            _RI.Set_Connection();
            _RI.Connection.Open();
            SqlCommand PSA_cmd = new SqlCommand(ps_access_value + value + "'", _RI.Connection);
            SqlCommand AOA_cmd = new SqlCommand(ao_access_value + value + "'", _RI.Connection);
            SqlCommand UOA_cmd = new SqlCommand(uo_access_value + value + "'", _RI.Connection);
            SqlCommand SZA_cmd = new SqlCommand(sz_access_value + value + "'", _RI.Connection);
            SqlCommand OFMSA_cmd = new SqlCommand(ofms_access_value + value + "'", _RI.Connection);
            SqlCommand ZAGSA_cmd = new SqlCommand(zags_access_value + value + "'", _RI.Connection);
            ps = Convert.ToInt16(PSA_cmd.ExecuteScalar().ToString());
            ao = Convert.ToInt16(AOA_cmd.ExecuteScalar().ToString());
            uo = Convert.ToInt16(UOA_cmd.ExecuteScalar().ToString());
            sz = Convert.ToInt16(SZA_cmd.ExecuteScalar().ToString());
            of = Convert.ToInt16(OFMSA_cmd.ExecuteScalar().ToString());
            za = Convert.ToInt16(ZAGSA_cmd.ExecuteScalar().ToString());
            Program.RG_PSA = ps;
            Program.RG_AOA = ao;
            Program.RG_UOA = uo;
            Program.RG_SZA = sz;
            Program.RG_OFMSA = of;
            Program.RG_ZAGSA = za;
            _RI.Connection.Close();
        }
    }
}
