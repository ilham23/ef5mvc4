using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RiderUniversity.Models;

namespace RiderUniversity.DAL
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentByID(int studentId);
        void InsertStudent(Student student);
    }
}