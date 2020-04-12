using School_Management.Models;
using System.Collections.Generic;
using School_Management.Repository;

namespace School_Management.Service
{
    public class StudentService : IStudentService
    {
        public IStudentRepository studentRepository;
        public StudentService(IStudentRepository studentRepository){
            this.studentRepository = studentRepository;
        }

        public void saveStudent(StudentModel student){
            studentRepository.saveStudent(student);
        }
        public List<StudentModel> getStudents(){
            List<StudentModel> allStudent = studentRepository.getStudents();
            return allStudent;
        }
        public void deleteStudent(StudentModel student){
            studentRepository.deleteStudent(student);
        }
        public void updateStudent(StudentModel student){
            studentRepository.updateStudent(student);
        }
    }
}