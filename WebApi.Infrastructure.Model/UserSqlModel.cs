﻿using System;

namespace WebApi.Infrastructure.Model
{
    public class UserSqlModel
    {
        public string UserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
