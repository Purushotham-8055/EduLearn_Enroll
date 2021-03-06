using ProjectSM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectSM.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectSM.Repository
{
    public class CourseRepository : ICourse
    {
        private DB_Context db;
        public CourseRepository(DB_Context _db)
        {
            db = _db;
        }
        public IEnumerable<Course> GetCourses => db.Courses;

        public void Add(Course _Course)
        {
            if (_Course.CourseId == 0)
            {
                db.Courses.Add(_Course);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Courses.Find(_Course.CourseId);
                dbEntity.CourseName = _Course.CourseName;
                dbEntity.Credits = _Course.Credits;
                db.SaveChanges();
            }


        }

        public Course GetCourse(int? Id)
        {
            return db.Courses.Include(e => e.Enrollments).ThenInclude(s => s.Students).SingleOrDefault(a => a.CourseId == Id);
        }

        public void Remove(int? Id)
        {
            Course dbEntity = db.Courses.Find(Id); ;
            db.Courses.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}