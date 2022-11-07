using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAkhir_Kel02
{
    class IDOtomatis
    {
        string result;
        public void setID(string firstText, string sp)
        {
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
                sqlCmd = new SqlCommand(sp, sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: {0}", ex);
            }
            result = firstText + num.ToString().PadLeft(3, '0');
        }

        public string getID()
        {
            return result;
        }
    }
}
