﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dot_net_web_api_project.Models
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string MailID { get; set; }
        public DateTime? DOJ { get; set; }
    }
}