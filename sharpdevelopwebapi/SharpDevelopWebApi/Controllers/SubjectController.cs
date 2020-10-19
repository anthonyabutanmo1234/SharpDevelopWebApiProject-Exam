using System;
using System.Web.Mvc;
using System.Web.Http;
using System.Collections.Generic;
using SharpDevelopWebApi.Models;
using System.Linq;
namespace SharpDevelopWebApi.Controllers
	
{
	/// <summary>
	 ///Description of SubjectController.
	///</summary>
	public class SubjectController : ApiController
	{
		[HttpGet]
		public IHttpActionResult GetAll()
		{
			SDWebApiDbContext _db = new SDWebApiDbContext();
		List<Subject> subject = _db.Subjects.ToList();
		
			return Ok(subject);
		}
		
}
}