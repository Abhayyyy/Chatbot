using EmergencySite.Core;
using EmergencySite.Core.Functions;
using EmergencySite.Persistence.AddContextRepositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmergencySite
{
    public partial class _Default : Page
    {
        private readonly ContextMessageRepository loginRepository;
        public _Default()
        {
            loginRepository = new ContextMessageRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsernameId.Text.Trim();
            var password = txtPasswordId.Text.Trim();

            if (string.IsNullOrEmpty(txtUsernameId.Text.Trim()) || string.IsNullOrEmpty(txtPasswordId.Text.Trim()))
            {
                ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR",
                                      "alert('Please Enter Username and Password.');", true);
                return;
            }

            var userInDb = await loginRepository.FindByUserName(username);
            if (userInDb != null)
            {
                if (password != GeneralFunctions.DecryptPassword(userInDb.EncryptedPassword))
                    ScriptManager.RegisterStartupScript(btnLogin, GetType(), "JSCR", "alert('Oops! wrong password., Try again');", true);
                else Response.Redirect("LandingPage.aspx");
            }

            //var login = new Login
            //{
            //    Username = username,
            //    Password = password,
            //    EncryptedPassword = GeneralFunctions.EncryptPassword(password.ToString()),
            //    ModifiedBy = username
            //}; 

            Session.Add("Username", txtUsernameId.Text.Trim());
            Session.Add("Password", txtPasswordId.Text.Trim());

            //using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=KLONdb;Integrated Security=True;"))
            //{
            //    string username = txtUsernameId.Text.Trim();
            //    string password = txtPasswordId.Text.Trim();

            //    var EncryptedPassword = GeneralFunctions.EncryptPassword(password);

            //    var currentDateTime = DateTime.Now;

            //    string data = $"INSERT INTO Logins(Username, Password, EncryptedPassword, CreatedAt, ModifiedAt, ModifiedBy) VALUES('{username}', '{password}', '{EncryptedPassword}', '{currentDateTime}', '{currentDateTime}', '{username}')";
            //    connection.Open();
            //    SqlCommand cmd = new SqlCommand(data, connection);

            //    cmd.ExecuteNonQuery();

            //    connection.Close();

            //    Response.Redirect("LandingPage.aspx");
            //}
        }
        protected void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            if (txtUsernameId.Text.ToString() == "")
            {
                ScriptManager.RegisterStartupScript(lnkForgotPassword, GetType(), "JSCR", "alert('Username is required.');", true);
                return;
            }
            Application["UserName"] = txtUsernameId.Text.Trim();
            Response.Redirect("~/Authentication/Sendotp.aspx");
        }
    }
}