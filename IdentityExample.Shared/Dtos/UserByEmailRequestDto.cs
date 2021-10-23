using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class UserByEmailRequestDto
    {
        [EmailAddress]
        public string Email { get; set; }
    }
}
