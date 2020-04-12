using School_Management.Models;
using School_Management.Repository;
using System.Collections.Generic;

namespace School_Management.Service
{
    public class TeacherService : ITeacherService
    {
        public IGenericRepository<TeacherModel> teacherRepository;
        public TeacherService(IGenericRepository<TeacherModel> teacherRepository){
            this.teacherRepository = teacherRepository;
        }
         public void saveTeacher(TeacherModel teacher){
             teacherRepository.saveData(teacher);
        }
        public List<TeacherModel> getTeachers(){
            List<TeacherModel> allTeacher = teacherRepository.getData();
            return allTeacher;
        }
        public void deleteTeacher(TeacherModel teacher){
            teacherRepository.deleteData(teacher);
        }
        public void updateTeacher(TeacherModel teacher){
            teacherRepository.updateData(teacher);
        }
    }
}