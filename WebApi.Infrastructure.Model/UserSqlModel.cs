using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Infrastructure.Model
{
    public class UserSqlModel
    {
        [Key]
        public string UserId { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
