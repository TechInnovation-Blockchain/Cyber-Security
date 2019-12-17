using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

using System.Configuration;
using System.Configuration.Provider;
using System.Data.Entity;
using MySql;
using MySql.Data;


namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/
        public ActionResult Index()
        {
            return View("");            
        }

        public ActionResult Showallinfo()
        {
            return Content("<script language='javascript' type='text/javascript'>alert('" + Session["Username"] + "');window.location.href='http://localhost:2231/';</script>"); 
            //return View("Showallinfo");
        }

        public ActionResult ShowLogHistory()
        {
            return View("LogHistory");
        }
        public ActionResult ShowAdminPanel()
        {
            return View("AdminPanel");
        }

        public ActionResult Logs()
        {
            return View("LogHistory");
        }

        public ActionResult ControlPanel()
        {
            return View("ControlPanel");
        }

        public JsonResult GetDataForRelationship()
        {
            //MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            //List<tbl_user_model> listreg = new List<tbl_user_model>();
            //MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_user", con);
            //MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //da.Fill(ds);

            //List<String> listreg1 = new List<String>();
            //List<String> listreg2 = new List<String>();
            //cmd = new MySqlCommand("SELECT * FROM tbl_cyber_crime_user", con);
            //MySqlDataAdapter da1 = new MySqlDataAdapter(cmd);
            //DataSet ds1 = new DataSet();
            //da1.Fill(ds1);

            //foreach (DataRow dr in ds1.Tables[0].Rows)
            //{
            //    listreg1.Add(
            //        dr["Case_name"].ToString()
            //    );
            //    listreg2.Add(
            //        dr["Username"].ToString()
            //    );
            //}

            //String str1 = "";
            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
                
            //    for (int i = 0; i < listreg1.Count; i ++)
            //    {
            //        if ((String.Compare(listreg2[i], dr["Username"].ToString(),false)) == 0)
            //        {
            //            if (i != (listreg1.Count - 1))
            //            {
            //                str1 += listreg1[i] + ", ";
            //            }
            //            else
            //            {
            //                str1 += listreg1[i];
            //            }
            //        }
                    
            //    }
                
            //    listreg.Add(new tbl_user_model
            //    {
            //        ID = Convert.ToInt32(dr["ID"]),
            //        Firstname = dr["Firstname"].ToString(),
            //        Middlename = dr["Middlename"].ToString(),
            //        Lastname = dr["Lastname"].ToString(),
            //        Username = dr["Username"].ToString(),
            //        Case_name = str1
                    
            //    });
            //    str1 = "";
            //}
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            List<tbl_cyber_crime_user> listreg = new List<tbl_cyber_crime_user>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_cyber_crime_user", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new tbl_cyber_crime_user
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Firstname = dr["Firstname"].ToString(),
                    Middlename = dr["Middlename"].ToString(),
                    Lastname = dr["Lastname"].ToString(),
                    Username = dr["Username"].ToString(),
                    Nationality = dr["Nationality"].ToString(),
                    Group_name = dr["Group_name"].ToString(),
                    Group_country = dr["Group_country"].ToString(),
                    Case_name = dr["Case_name"].ToString(),
                    Case_text = dr["Case_text"].ToString(),
                    ID_type = dr["ID_type"].ToString(),
                    B_Account_number = dr["B_Account_number"].ToString(),
                    B_Account_country = dr["B_Account_country"].ToString(),
                    B_Account_type = dr["B_Account_type"].ToString(),
                    E_Account_name = dr["E_Account_name"].ToString(),
                    E_Account_typename = dr["E_Account_typename"].ToString(),
                    IPs_ip = dr["IPs_ip"].ToString(),
                    IPs_country = dr["IPs_country"].ToString(),
                    Skill_name = dr["Skill_name"].ToString(),
                    Skill_text = dr["Skill_text"].ToString(),
                    Skill_type = dr["Skill_type"].ToString()

                });
            }
            return Json(listreg, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AllLogHistory()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            List<tbl_log_history> listreg = new List<tbl_log_history>();
            MySqlCommand cmd = new MySqlCommand("select * from tbl_log_history", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new tbl_log_history
                {
                    Username = dr["Username"].ToString(),
                    Action = dr["Action"].ToString(),
                    Time = dr["ModifiedTime"].ToString()
                });
            }

            return Json(listreg, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDataForUser()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            List<tbl_user_model> listreg = new List<tbl_user_model>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_user", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new tbl_user_model
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Firstname = dr["Firstname"].ToString(),
                    Middlename = dr["Middlename"].ToString(),
                    Lastname = dr["Lastname"].ToString(),
                    Username = dr["Username"].ToString(),
                    Password = dr["Password"].ToString(),
                    Permission = dr["Permission"].ToString()

                });
            }
            return Json(listreg, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDataForReport()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            List<report_model> listreg = new List<report_model>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_report", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //foreach (DataRow dr in ds.Tables[0].Rows)
            //{
            //    listreg.Add(new tbl_user_model
            //    {
            //        ID = Convert.ToInt32(dr["ID"]),
            //        Firstname = dr["Firstname"].ToString(),
            //        Middlename = dr["Middlename"].ToString(),
            //        Lastname = dr["Lastname"].ToString(),
            //        Username = dr["Username"].ToString(),
            //        Password = dr["Password"].ToString(),
            //        Permission = dr["Permission"].ToString()

            //    });
            //}
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new report_model
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Username = dr["Username"].ToString(),
                    Text = dr["Text"].ToString(),
                });
            }
            
            return Json(listreg, JsonRequestBehavior.AllowGet);
        }

       
        public void EditUser(List<String> parse_data)
        {
            if (parse_data[0] == "add")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_user (Firstname, Middlename, Lastname, Username, Password, Permission) VALUES ('" + parse_data[1] + "','" + parse_data[2] + "','" + parse_data[3] + "','" + parse_data[4] + "','" + parse_data[5] + "','" + parse_data[6] + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                con.Close();

                MySqlConnection con1 = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con1.Open();
                var time = DateTime.Now;
                string formattedTime = time.ToString("yyyy-MM-dd hh:mm:ss");
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO tbl_log_history (Username, Action, ModifiedTime) VALUES ('" + "Admin" + "','" + "CreateUser" + "','" + formattedTime + "')", con1);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteScalar();
                con1.Close();

            }
            else if (parse_data[0] == "remove")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from tbl_user where ID='" + parse_data[1] + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                con.Close();

                MySqlConnection con1 = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con1.Open();
                var time = DateTime.Now;
                string formattedTime = time.ToString("yyyy-MM-dd hh:mm:ss");
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO tbl_log_history (Username, Action, ModifiedTime) VALUES ('" + "Admin" + "','" + "Remove User" + "','" + formattedTime + "')", con1);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteScalar();
                con1.Close();
            }
            else if (parse_data[0] == "edit")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("update tbl_user set Firstname = '" + parse_data[1] + "', Middlename = '" + parse_data[2] + "', Lastname = '" + parse_data[3] + "', Username = '" + parse_data[4] + "', Password = '" + parse_data[5] + "', Permission = '" + parse_data[6] + "' where ID='" + parse_data[7] + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                con.Close();

                MySqlConnection con1 = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con1.Open();
                var time = DateTime.Now;
                string formattedTime = time.ToString("yyyy-MM-dd hh:mm:ss");
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO tbl_log_history (Username, Action, ModifiedTime) VALUES ('" + "Admin" + "','" + "Edit User" + "','" + formattedTime + "')", con1);
                cmd1.CommandType = CommandType.Text;
                cmd1.ExecuteScalar();
                con1.Close();
            }
        }

        public ActionResult SearchCase()
        {
            return View("SearchCase");
        }

        public ActionResult NewCase()
        {
            return View("NewCase");
        }


        public JsonResult GetDataForCase()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
            List<tbl_cyber_crime_user> listreg = new List<tbl_cyber_crime_user>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_cyber_crime_user", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                listreg.Add(new tbl_cyber_crime_user
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Firstname = dr["Firstname"].ToString(),
                    Middlename = dr["Middlename"].ToString(),
                    Lastname = dr["Lastname"].ToString(),
                    Username = dr["Username"].ToString(),
                    Group_name = dr["Group_name"].ToString(),
                    Group_country = dr["Group_country"].ToString(),
                    Case_name = dr["Case_name"].ToString(),
                    Case_text = dr["Case_text"].ToString(),
                    ID_type = dr["ID_type"].ToString(),
                    B_Account_number = dr["B_Account_number"].ToString(),
                    B_Account_country = dr["B_Account_country"].ToString(),
                    B_Account_type = dr["B_Account_type"].ToString(),
                    E_Account_name = dr["E_Account_name"].ToString(),
                    E_Account_typename = dr["E_Account_typename"].ToString(),
                    IPs_ip = dr["IPs_ip"].ToString(),
                    IPs_country = dr["IPs_country"].ToString(),
                    Skill_name = dr["Skill_name"].ToString(),
                    Skill_text = dr["Skill_text"].ToString(),
                    Skill_type = dr["Skill_type"].ToString(),
                    Nationality = dr["Nationality"].ToString(),
                    ModifyTime = dr["ModifyTime"].ToString()
                });
            }
            return Json(listreg, JsonRequestBehavior.AllowGet);
        }


        //Display Edit Case Page
        public ActionResult EditCase()
        {
            return View("EditCase");
        }

        public ActionResult Reports()
        {
            return View("Report");
        }

        public void AddCase(List<String> parse_data)
        {
            if (parse_data[0] == "add")
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_cyber_crime_user (Firstname, Middlename, Lastname, Nationality, Group_name, Group_country, Case_name, Case_text, B_Account_number, B_Account_country, B_Account_type, E_Account_name, E_Account_typename, IPs_ip, IPs_country, Skill_name, Skill_text, Skill_type, Username, ID_type, ModifyTime) VALUES ('" + parse_data[1] + "','" + parse_data[2] + "','" + parse_data[3] + "','" + parse_data[4] + "','" + parse_data[5] + "','" + parse_data[6] + "','" + parse_data[7] + "','" + parse_data[8] + "','" + parse_data[9] + "','" + parse_data[10] + "','" + parse_data[11] + "','" + parse_data[12] + "','" + parse_data[13] + "','" + parse_data[14] + "','" + parse_data[15] + "','" + parse_data[16] + "','" + parse_data[17] + "','" + parse_data[18] + "','" + parse_data[21] + "','" + parse_data[19] + "','" + parse_data[20] + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                con.Close();
            }
            else if(parse_data[0] == "remove"){
                var delete_id = parse_data[1];
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_cyber_crime_user WHERE ID='" + delete_id + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                con.Close();
            }
            else if(parse_data[0] == "update")
            {
                var first = parse_data[1];
                var second = parse_data[2];
                var third = parse_data[3];
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=root;database=cyber_db;port=3316;");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE tbl_cyber_crime_user SET Firstname = '" + parse_data[1] + "', Middlename = '" + parse_data[2] + "', Lastname = '" + parse_data[3] + "', Nationality = '" + parse_data[4] + "', Group_name = '" + parse_data[5] + "', Group_country = '" + parse_data[6] + "', Case_name = '" + parse_data[7] + "', Case_text = '" + parse_data[8] + "', B_Account_number = '" + parse_data[9] + "', B_Account_country = '" + parse_data[10] + "', B_Account_type = '" + parse_data[11] + "', E_Account_name = '" + parse_data[12] + "', E_Account_typename = '" + parse_data[13] + "', IPs_ip = '" + parse_data[14] + "', IPs_country = '" + parse_data[15] + "', Skill_name = '" + parse_data[16] + "', Skill_text = '" + parse_data[17] + "', Skill_type = '" + parse_data[18] + "', ID_type = '" + parse_data[20] + "', ModifyTime = '" + parse_data[22] + "' WHERE ID='" + parse_data[21] + "'", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteScalar();
                con.Close();
            }
        }

        public ActionResult Logout()
        {
            return View("../home/index");
        }

	}

}