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
	/// Description of StudentGradeController.
	/// </summary>
public class StudentGradeController : ApiController
	{
	
	
	SDWebApiDbContext _db = new SDWebApiDbContext();
		
		
		[HttpPost]
		public IHttpActionResult Create(StudentGrade grade)
		{
			_db.StudentGrades.Add(grade);
			_db.SaveChanges();
			return Ok(grade);
		
		}
		
		
}
}