using Microsoft.AspNetCore.Mvc;
using School_Management.Models;
using System.Collections.Generic;
using School_Management.Service;

namespace School_Management.Controllers
{
    public class TeacherController : Controller
    {
        public ITeacherService teacherService;
        public TeacherController(ITeacherService teacherService){
            this.teacherService = teacherService;
        }
         public IActionResult addTeacher(){
            return View();
        }
        [HttpPost]
        public IActionResult saveTeacher(TeacherModel teacher){
            teacherService.saveTeacher(teacher);
            return Redirect("teacherHome");
        }
        public IActionResult teacherHome(){
            List<TeacherModel> allTeacher  = teacherService.getTeachers();
            return View(allTeacher);
        }
        public IActionResult deleteTeacher(TeacherModel teacher){
            teacherService.deleteTeacher(teacher);
            return Redirect("teacherHome");
        }
        public IActionResult editTeacher(TeacherModel teacher){
            return View(teacher);
        }
        [HttpPost]
        public IActionResult updateTeacher(TeacherModel teacher){
            teacherService.updateTeacher(teacher);
            return Redirect("teacherHome");
        }   
    }
}