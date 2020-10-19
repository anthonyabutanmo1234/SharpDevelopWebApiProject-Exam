using System;
using System.Web.Mvc;
using System.Web.Http;
using System.Collections.Generic;
using SharpDevelopWebApi.Models;
using System.Linq;

namespace SharpDevelopWebApi.Controllers
{
	/// <summary>
	/// Description of StudentController.
	/// </summary>
	public class StudyanteController : ApiController
	{

		SDWebApiDbContext _db = new SDWebApiDbContext();
		[Route("api/song/getsong")]
		[HttpGet]
		public IHttpActionResult GetAll()
		{
			
			List<Studyante> studyante = _db.Studyantes.ToList();
			_db.SaveChanges();
			return Ok(studyante);
		}
		
		[HttpGet]
		public IHttpActionResult Get()
		{
			var studyantes = new Studyante();
			studyantes.SchoolLastAttended = "COC";
			studyantes.CourseId = "IT";
			return Ok(studyantes);
			
			
		}
		[HttpPost]
		public IHttpActionResult Create([FromBody]Studyante studyante)
		{
			_db.Studyantes.Add(studyante);
			return Ok("Successfully Entered");
		}
	
	}
}