using System;
using System.ComponentModel.DataAnnotations;

namespace MVCCoreTutorialDemo.Models.Domain
{
	public class Person
	{
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
	}
}

