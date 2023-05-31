using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Assignment2.Models
{
    public class StudentDetails
    {

        public int studentid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int standard { get; set; }
        public string address { get; set; }

        public Marks Marks { get; set; }

    }
}
