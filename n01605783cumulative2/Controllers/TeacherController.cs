using n01605783cumulative2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace n01605783cumulative2.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        // GET: Teacher/List
        // Go to /Views/Teacher/List.cshtml
        // Browser opens a list teachers page
        public ActionResult List()
        {
            // we need to pass teacher information to the view

            // create an instance of the teacher data controller

            TeacherDataController Controller = new TeacherDataController();



            IEnumerable<Teacher> enumerable = Controller.ListTeacherData();
            List<Teacher> Teachers = (List<Teacher>)enumerable;

            // pass the teachers information to the /Views/Teacher/List.cshtml
            return View(Teachers);
        }
        // GET : /Teacher/Show/{Id}
        //Route to /Views/Teacher/Show.cshtml
        public ActionResult Show(int id)
        {
            TeacherDataController Controller = new TeacherDataController();

            Teacher SelectedTeacher = Controller.FindTeacher(id);
            // we want to show a particular teacher given the id
            return View(SelectedTeacher);
        }

        public ActionResult New()
        {
            return View();
        }
        public ActionResult Create(string TeacherFname, string TeacherLname, DateTime TeacherHireDate, string TeacherSalary, string TeacherEmployeeNumber)
        {
            //Identify that this method is running
            //Identify the inputs provided from the form

            Debug.WriteLine("I have accessed the Create Method!");
            Debug.WriteLine(TeacherFname);
            Debug.WriteLine(TeacherLname);
            Debug.WriteLine(TeacherHireDate);
            Debug.WriteLine(TeacherSalary);
            Debug.WriteLine(TeacherEmployeeNumber);

            Teacher NewTeacher = new Teacher();
            NewTeacher.TeacherFirstName = TeacherFname;
            NewTeacher.TeacherLastName = TeacherLname;
            NewTeacher.TeacherHireDate = TeacherHireDate;
            NewTeacher.TeacherSalary = TeacherSalary;
            NewTeacher.TeacherEmployeeNumber = TeacherEmployeeNumber;

            TeacherDataController controller = new TeacherDataController();
            controller.AddTeacher(NewTeacher);

            return RedirectToAction("List");
        }
    }
}