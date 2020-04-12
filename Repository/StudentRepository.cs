// using School_Management.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace School_Management.Repository
// {
//     public class StudentRepository : IStudentRepository
//     {
//         public SchoolContext context = new SchoolContext();
//         public void saveStudent(StudentModel student){
//             context.Students.Add(student);
//             context .SaveChanges();
//         }
//         public List<StudentModel> getStudents(){
//             List<StudentModel> allStudent = context.Students.ToList();
//             return allStudent;
//         }
//         public void deleteStudent(StudentModel student){
//             context.Students.Remove(student);
//             context.SaveChanges();
//         }
//         public void updateStudent(StudentModel student){
//             context.Students.Update(student);
//             context.SaveChanges();
//         }
//     }
// }