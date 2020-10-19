using System;
using System.Web.Mvc;
using System.Web.Http;
using System.Collections.Generic;
using SharpDevelopWebApi.Models;
using System.Linq;
namespace SharpDevelopWebApi.Controllers
{
	/// <summary>
	/// Description of CourseController.
	/// </summary>
	public class CourseController : ApiController
	{
	[HttpGet]
		public IHttpActionResult GetAll()
		{
			SDWebApiDbContext _db = new SDWebApiDbContext();
			List<Course> course = _db.Courses.ToList();
		
			return Ok(course);
		}
	}
}