using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Helpers;
using System.Web.Security;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void LogoutButton_Click(object sender, EventArgs e)
    {

        System.Web.HttpContext.Current.Session.Abandon();
        //Session.Abandon();
        Response.Redirect("Default.aspx");
       

    }
    protected void Login_Authenticate(object sender, EventArgs e)
    {
        
        
    }

    protected void LoginButton_Click(object sender, EventArgs e)
    {
        {

            string name = TextBox1.Text;
            string pass = TextBox2.Text;


            //Console.WriteLine(Session["FirstName"].ToString());

            Application.Lock();
            Dictionary<string, string> ValidUsers = (Dictionary<string, string>)Application["UsernameList"];
            string passwd;

            if (name == null || pass == null || name.Length == 0 || pass.Length == 0)
            {
                Label1.Enabled = true;
                Label1.Text = "Empty username or password, please try again.";
            }
            else
            {

                if (ValidUsers.TryGetValue(name, out passwd))
                {

                    if ((Crypto.VerifyHashedPassword(passwd, pass)))
                    {

                        Session["FirstName"] = name;
                        Session["Pass"] = pass;
                        Session.Timeout = 1;
                        Session["SessionID"] = Guid.NewGuid().ToString();
                        string sess = Session["SessionID"].ToString();
                        Session["Timeout"] = 1;
                        HttpCookie usercookie = new HttpCookie("user");
                        usercookie.Values["FirstName"] = name;
                        usercookie.Values["SessionID"] = Crypto.HashPassword(Session["SessionID"].ToString()).ToString();
                        usercookie.Expires = DateTime.Now.AddHours(2);
                        Response.Cookies.Add(usercookie);
                        Panel1.Visible = false;
                        Response.Redirect("TicTAcToe.aspx");
                       

                    }
                    else
                    {
                        Label1.Enabled = true;
                        Label1.Text = "Invalid username or password, please try again.";
                    }

                }

                else
                {
                    ValidUsers.Add(name, Crypto.HashPassword(pass));
                    Session["FirstName"] = name;
                    Session["Pass"] = pass;
                    Session.Timeout = 1;
                    Session["SessionID"] = Guid.NewGuid().ToString();
                    string sess = Session["SessionID"].ToString();
                    Session["Timeout"] = 1;
                    HttpCookie usercookie = new HttpCookie("user");
                    usercookie.Values["FirstName"] = name;
                    usercookie.Values["SessionID"] = Crypto.HashPassword(Session["SessionID"].ToString()).ToString();
                    usercookie.Expires = DateTime.Now.AddHours(2);
                    Response.Cookies.Add(usercookie);
                    Panel1.Visible = false;
                    Response.Redirect("TicTacToe.aspx");
                    

                }

                Application.UnLock();
            }



        }
    }
}