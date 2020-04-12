using Microsoft.AspNetCore.Mvc;
using School_Management.Models;
using School_Management.Service;
using System.Collections.Generic;

namespace School_Management.Controllers
{
    public class StudentController : Controller
    {
        public IStudentService studentService;
        public StudentController(IStudentService studentService){
            this.studentService = studentService;
        }

        public IActionResult addStudent(){
            return View();
        }

        [HttpPost]
        public IActionResult saveStudent(StudentModel student){
            studentService.saveStudent(student);
            return Redirect("index");
        }

        public IActionResult index(){
            List<StudentModel> allStudent =  studentService.getStudents();
            return View(allStudent);
        }

        public IActionResult deleteStudent(StudentModel student){
            studentService.deleteStudent(student);
            return Redirect("index");
        }

        public IActionResult editStudent(StudentModel student){
            return View(student);
        }

        [HttpPost]
        public IActionResult updateStudent(StudentModel student){
            studentService.updateStudent(student);
            return Redirect("index");
        }
    }
}