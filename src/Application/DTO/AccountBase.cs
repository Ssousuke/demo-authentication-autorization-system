﻿using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class AccountBase
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string? Password { get; set; }
    }
}