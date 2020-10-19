using System;
using System.Web.Mvc;
using System.Web.Http;
using System.Collections.Generic;
using SharpDevelopWebApi.Models;
using System.Linq;

namespace SharpDevelopWebApi.Controllers
{
	/// <summary>
	/// Description of FacultyController.
	/// </summary>
	/// public class StudyanteController : ApiController
	public class FacultyController : ApiController
	{
		[HttpGet]
		public IHttpActionResult GetAll()
		{
			SDWebApiDbContext _db = new SDWebApiDbContext();
			List<Faculty> faculty = _db.Facultys.ToList();
		
			return Ok(faculty);
		}
	}
}