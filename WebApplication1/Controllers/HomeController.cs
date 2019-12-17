using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Configuration.Provider;
using System.Data.Entity;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult checkuser(tbl_user_model data)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from tbl_user where Username=@Username and Password=@Password", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", data.Username);
            cmd.Parameters.AddWithValue("@Password", data.Password);
            object obj = cmd.ExecuteScalar();

            if (Convert.ToInt32(obj) != 0)
            {
                
                Session["Username"] = data.Username;
                cmd = new MySqlCommand("SELECT * FROM tbl_user WHERE Username='"+data.Username +"' AND Password='"+data.Password+"'", con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                Session["Permission"] = ds.Tables[0].Rows[0]["Permission"].ToString();
                Session["username"] = data.Username;
                con.Close();

                MySqlConnection con1 = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con1.Open();
                var time = DateTime.Now;
                string formattedTime = time.ToString("yyyy-MM-dd hh:mm:ss");
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO tbl_log_history (Username, Action, ModifiedTime) VALUES ('" + Session["Username"] + "','" + "Login" + "','" + formattedTime + "')", con1);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteScalar();
                con1.Close();

                return View("../Main/index");
            }
            else
            {   
                con.Close();
                return Content("<script language='javascript' type='text/javascript'>alert('Wrong Username or Password!');window.location.href='http://localhost:2231/';</script>");
            }
            
                  
        }
    }
}