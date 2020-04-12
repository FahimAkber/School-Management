using School_Management.Models;
using System.Collections.Generic;

namespace School_Management.Service
{
    public interface IStudentService
    {
         void saveStudent(StudentModel student);
         List<StudentModel> getStudents();
         void deleteStudent(StudentModel student);
         void updateStudent(StudentModel student);
    }
}