using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingDropdownProject.Models;

namespace CascadingDropdownProject.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students

        public static List<Student> Students = new List<Student>()
        {
            new Student(){Id = 1,Name = "Mahmud",Code = "001",DepartmentId = 1},
            new Student(){Id = 2,Name = "Faisal",Code = "002",DepartmentId = 2}
        };
        public static List<Department> Departments = new List<Department>()
        {
            new Department(){Id = 1,Name = "CSE",Code = "001"},
            new Department(){Id = 2,Name = "EEE",Code = "002"}
        };

        public ActionResult Create()
        {
            return View();
        }

        public JsonResult GetDepartments()
        {
            var dataList = Departments.ToList();
            var jsonData = dataList.Select(c => new { Id = c.Id, Name = c.Name });
            return Json(jsonData);
        }
        public JsonResult GetStudentsByDepartmentId(int id)
        {
            var dataList = Students.Where(c => c.DepartmentId == id).ToList();
            var jsonResult = dataList.Select(c => new { Id = c.Id, Name = c.Name, DepartmentId = c.DepartmentId });
            return Json(jsonResult);
        }
    }
}