/*
 * Created by SharpDevelop.
 * User: My PC
 * Date: 10/19/2020
 * Time: 9:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using Newtonsoft.Json;

namespace SharpDevelopWebApi.Models
{

	public class Studyante
	{
		
		public string SchoolLastAttended { get; set; }
		public string CourseId { get; set; }
			
		

    }
}