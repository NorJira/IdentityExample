using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class RefreshTokenRequestDto
    {
        [Required]
        public string Token { get; set; }
    }
}
