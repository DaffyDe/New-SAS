using Microsoft.AspNetCore.Mvc;
using Student_Attendance_System.Models;

namespace Student_Attendance_System.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // This loads the Page
        public IActionResult Index()
        {
            return View();
        }

        // API: Get all students
        [HttpGet]
        public IActionResult GetAll()
        {
            var students = _context.Students.ToList();
            return Json(students);
        }

        // API: Add a student
        [HttpPost]
        public IActionResult Create([FromBody] Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return Ok();
        }
    }
}