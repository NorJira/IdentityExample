using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.Shared.Dtos
{
    public class DeleteRequestDto
    {
        [Required]
        public string Id { get; set; }
    }
}
