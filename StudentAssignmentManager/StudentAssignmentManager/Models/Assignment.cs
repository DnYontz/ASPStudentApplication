using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAssignmentManager.Models
{
    public class Assignment
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateEntered { get; set; }
        public string ClassName { get; set; }
        public string Details { get; set; }
    }
}