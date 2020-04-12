using School_Management.Models;
using System.Collections.Generic;

namespace School_Management.Repository
{
    public interface ITeacherRepository
    {
         void saveTeacher(TeacherModel teacher);
         List<TeacherModel> getTeachers();
         void deleteTeacher(TeacherModel teacher);
         void updateTeacher(TeacherModel teacher);
    }
}