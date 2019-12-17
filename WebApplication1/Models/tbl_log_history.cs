using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class tbl_log_history
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Action { get; set; }
        public string Time { get; set; }
    }
}