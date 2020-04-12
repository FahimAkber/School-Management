using School_Management.Models;
using School_Management.Repository;
using System.Collections.Generic;

namespace School_Management.Service
{
    public class TeacherService : ITeacherService
    {
        public ITeacherRepository teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository){
            this.teacherRepository = teacherRepository;
        }
         public void saveTeacher(TeacherModel teacher){
             teacherRepository.saveTeacher(teacher);
        }
        public List<TeacherModel> getTeachers(){
            List<TeacherModel> allTeacher = teacherRepository.getTeachers();
            return allTeacher;
        }
        public void deleteTeacher(TeacherModel teacher){
            teacherRepository.deleteTeacher(teacher);
        }
        public void updateTeacher(TeacherModel teacher){
            teacherRepository.updateTeacher(teacher);
        }
    }
}