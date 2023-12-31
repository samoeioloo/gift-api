﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Gift.Models.Requests
{
	public class UserSignupRequest
	{
		[Required]
		public string? Username { get; set; }
		[Required]
		public string? Password { get; set; }
		[Required]
		public string? Email { get; set; }

	}
}

