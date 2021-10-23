using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}
