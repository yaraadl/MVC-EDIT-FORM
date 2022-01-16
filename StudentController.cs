using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student = WebApplication2.Models.Student;


namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> Studentlist = new List<Student>{
       
            new Student(){studentid=1,studentname="yara",age=20},
            new Student(){studentid=2,studentname="alaa",age=22},
            new Student(){studentid=3,studentname="bassant",age=21}
        };
  
        //
        // GET: /Student/
        public ActionResult Index()
        {
             
            return View(Studentlist.OrderBy(S => S.studentid).ToList());
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = Studentlist.Where(s => s.studentid == id).FirstOrDefault();
            return View(std);
        
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var Student = Studentlist.Where(S => S.studentid == std.studentid).FirstOrDefault();
            Studentlist.Remove(Student);
            Studentlist.Add(std);
            return RedirectToAction("Index");
        }


        

  
	}
}