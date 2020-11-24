using System.Web;
using SharpDevelopWebApi.Helpers.JWT;
using SharpDevelopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace SharpDevelopWebApi.Controllers
{
	/// <summary>
	/// Description of StudentController.
	/// </summary>
	public class StudentController : ApiController
	{
		SDWebApiDbContext _db = new SDWebApiDbContext();
		[HttpGet]
		public IHttpActionResult Getall(string StudentID="")
		{
			StudentID = StudentID.Trim();
			var students = new List<Stud>();
			
			if(!string.IsNullOrEmpty(StudentID))
			{
				students = _db.Student
					.Where(x=> x.StudentId.Contains(StudentID))
					.ToList();
			
			}
		 
			else
				students = _db.Student.ToList();
			
			return Ok(students);
		}
		
		[HttpPost]
		public IHttpActionResult Create(Stud NewStudent)
		{
			_db.Student.Add(NewStudent);
			_db.SaveChanges();
			return Ok(NewStudent);
		
		}
		
		
	
		  [HttpPut]
        public IHttpActionResult Update(Stud updatedstud)
        {
            var student = _db.Student.Find(updatedstud.Id);
            if (student != null)
            {
                student.LastName = updatedstud.LastName;
                student.Firstname = updatedstud.Firstname;
                student.Gender = updatedstud.Gender;
                student.StudentId = updatedstud.StudentId;
                student.SubjectId = updatedstud.SubjectId;
                student.CivilStatus = updatedstud.CivilStatus;
                student.P1Grade = updatedstud.P1Grade;
                student.P2Grade = updatedstud.P2Grade;
                student.P3Grade = updatedstud.P3Grade;
                student.SchoolLastAttended = updatedstud.SchoolLastAttended;
                student.CourseId = updatedstud.CourseId;
                

                _db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                return Ok(student);
            }
            else
                return BadRequest("Student not found");
        }

		
		
		
		public IHttpActionResult Delete(int Id)
		{
			var student = _db.Student.Find(Id);
			if(student != null)
			{
				_db.Student.Remove(student);
				_db.SaveChanges();
				
				return BadRequest("Student successfully Deleted!");
				
			
			}
			else
				return BadRequest("Not found...");
		
		}
		
	}
}