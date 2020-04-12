// using School_Management.Models;
// using System.Linq;
// using System.Collections.Generic;

// namespace School_Management.Repository
// {
//     public class TeacherRepository : ITeacherRepository
//     {
//         public SchoolContext context = new SchoolContext();
//         public void saveTeacher(TeacherModel teacher){
//             context.Teachers.Add(teacher);
//             context.SaveChanges();
//         }
//         public List<TeacherModel> getTeachers(){
//             List<TeacherModel> allTeacher = context.Teachers.ToList();
//             return allTeacher;
//         }
//         public void deleteTeacher(TeacherModel teacher){
//                 context.Teachers.Remove(teacher);
//                 context.SaveChanges();
//         }
//         public void updateTeacher(TeacherModel teacher){
//             context.Teachers.Update(teacher);
//             context.SaveChanges();
//         }
//     }
// }