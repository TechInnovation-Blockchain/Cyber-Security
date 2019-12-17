using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class tbl_cyber_crime_user
    {
        [Key]
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Nationality { get; set; }
        public string Group_name { get; set; }
        public string Group_country { get; set; }
        public string Case_name { get; set; }
        public string Case_text { get; set; }
        public string ID_type { get; set; }
        public string B_Account_number { get; set; }
        public string B_Account_country { get; set; }
        public string B_Account_type { get; set; }
        public string E_Account_name { get; set; }
        public string E_Account_typename { get; set; }
        public string IPs_ip { get; set; }
        public string IPs_country { get; set; }
        public string Skill_name { get; set; }
        public string Skill_text { get; set; }
        public string Skill_type { get; set; }
        public string Username { get; set; }
        public string ModifyTime { get; set; }
    }
}