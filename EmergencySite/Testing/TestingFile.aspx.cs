using EmergencySite.Core.Functions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace EmergencySite.Testing
{
    public partial class TestingFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; database=dbCorona; integrated security=SSPI;"))
            //using (SqlConnection connection = new SqlConnection(@"server=192.168.0.244; database=ebotprod; user id=sa; password=Shoaib!@#123;"))
            {
                var arrName = new ArrayList();

                using (SqlCommand cmd_1 = new SqlCommand("Select Password from Logins", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd_1.ExecuteReader();
                    
                    if (reader != null)
                    {
                        while (reader.Read())
                        {
                            var pass = arrName.Add(reader["Password"]);
                        }
                        reader.Close();
                        connection.Close();
                        foreach (var item in arrName)
                        {
                            var encryptedPassword = GeneralFunctions.EncryptPassword(item.ToString());

                            using (SqlCommand cmd_2 = new SqlCommand($"UPDATE Logins  SET EncryptedPassword = '{encryptedPassword}' WHERE Password = '{item}'", connection))
                            {
                                SqlParameter param = new SqlParameter("@EncryptedPassword", SqlDbType.VarChar);
                                connection.Open();
                                cmd_2.ExecuteNonQuery();
                                connection.Close();
                            }
                        }
                        //Response.Redirect("MohitEncryptionData.aspx");
                    }                   
                }             
                              
            }

            ScriptManager.RegisterStartupScript(
                    btnEButton,
                    GetType(),
                    "JSCR",
                    "alert('Success.');",
                    true);
        }
    }
}

