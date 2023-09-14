using System;
using System.ComponentModel.DataAnnotations;

namespace Gift.Models.Requests
{
	public class AuthenticateRequest
	{
		[Required]
		public string? Username { get; set; }
		[Required]
		public string? Password { get; set; }
	}
}

