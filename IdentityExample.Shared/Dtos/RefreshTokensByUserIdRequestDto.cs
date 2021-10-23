using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class RefreshTokensByUserIdRequestDto
    {
        [Required]
        public string Id { get; set; }
    }
}
