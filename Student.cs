using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Student = WebApplication2.Models.Student;

namespace WebApplication2.Models
{
    public class Student
    {
        
            public int studentid { get; set; }
    [Display( Name="Name")]
            public String studentname { get; set; }
            public int age { get; set; }
        
    }

   

    

}