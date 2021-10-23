using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class ForgetPasswordRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
