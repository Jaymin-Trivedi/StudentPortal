using Microsoft.EntityFrameworkCore;
using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentApp.Domain
{
    public class StudentDomain
    {

        public void AddStudent(Student student)
        {
            var db = new EFContext();
            db.Students.Add(new Student() 
                {
                StudentName=student.StudentName,
                Mobile=student.Mobile,
                Course=student.Course,
                Emaiol=student.Emaiol,
                Fee=student.Fee
            });
            db.SaveChanges();
        }

        public List<Student> GetAll()
        {
            var db = new EFContext();
            var students = db.Students.ToList();
            return students;
        }

        public Student GetById(int id)
        {
            var db = new EFContext();
            var student = db.Students.SingleOrDefault(t => t.StudentId == id);

            return student;
        }
        public void UpdateStudent(int id,Student student)
        {
            var db = new EFContext();
            var student1 = db.Students.SingleOrDefault(t => t.StudentId == id);
            student1.StudentName = student.StudentName;
            student1.Mobile = student.Mobile;
            student1.Course = student.Course;
            student1.Emaiol = student.Emaiol;
            student1.Fee = student.Fee;
            db.Entry(student1).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void deleteStudent(int id)
        {
            var db = new EFContext();
            try
            {
                db.Students.Remove(db.Students.Single(t => t.StudentId == id));
                db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

    }

}