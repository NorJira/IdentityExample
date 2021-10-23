using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class ValidateResetTokenRequestDto
    {
        [Required]
        public string Token { get; set; }
    }
}
