﻿using System.ComponentModel.DataAnnotations;

namespace CompanyManagementSystem.PL.ViewModels
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "First Name is required")]
		public string FName { get; set; }

		[Required(ErrorMessage = "Last Name is required")]
		public string LName { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm Password is required")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
		public string ConfirmPassword { get; set; }

		public bool IsAgree { get; set; }
	}
}
