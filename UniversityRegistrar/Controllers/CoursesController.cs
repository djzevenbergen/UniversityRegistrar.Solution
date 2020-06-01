using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using UniversityRegistrar.Models;

namespace UniversityRegistrar.Controllers
{
  public class CoursesController : Controller{
    private readonly UniversityRegistrarContext _db;

    public CoursesController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Course> model = _db.Courses.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Course course)
    {
      _db.Courses.Add(course);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // [HttpGet("/search")]
    // public ActionResult Search(string search)
    // {
    //   List<Course> model = _db.Courses.Include(courses => courses.Students).ToList();
    //   List<Student> studentModel = _db.Students.Include(students => students.Students).ToList();

    //   Student studentMatch = new Student();
    //   Course match = new Course();

    //   if (!string.IsNullOrEmpty(search))
    //   {
    //    foreach(Course course in model)
    //    {
    //      if (course.Name == search)
    //      {
    //        match = course;
    //      }
    //    } 
    //   }

    //   List<CourseStudent> matches = match.Students.ToList();
    //   return View(matches);
    // }
  }
}