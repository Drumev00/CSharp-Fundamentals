﻿using System.ComponentModel.DataAnnotations;

namespace RescueRegister.Models
{
    public class Mountaineer
    {
        //TODO: Implement me

		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public int Age { get; set; }

		[Required]
		public string Gender { get; set; }

		[Required]
		public string LastSeenDate { get; set; }
	}
}
