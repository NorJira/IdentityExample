using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class AuthenticateRequestDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
