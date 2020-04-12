using School_Management.Models;
using System.Collections.Generic;
using School_Management.Repository;

namespace School_Management.Service
{
    public class StudentService : IStudentService
    {
        public IGenericRepository<StudentModel> studentRepository;
        public StudentService(IGenericRepository<StudentModel> studentRepository){
            this.studentRepository = studentRepository;
        }

        public void saveStudent(StudentModel student){
            studentRepository.saveData(student);
        }
        public List<StudentModel> getStudents(){
            List<StudentModel> allStudent = studentRepository.getData();
            return allStudent;
        }
        public void deleteStudent(StudentModel student){
            studentRepository.deleteData(student);
        }
        public void updateStudent(StudentModel student){
            studentRepository.updateData(student);
        }
    }
}