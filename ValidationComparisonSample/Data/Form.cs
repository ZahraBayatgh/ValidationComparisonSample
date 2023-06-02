﻿using System.ComponentModel.DataAnnotations;

namespace ValidationComparisonSample.Data;

public class Form
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = null!;
}
