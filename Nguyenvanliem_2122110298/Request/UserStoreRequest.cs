﻿namespace Nguyenvanliem_2122110298.Request
{
    public class UserStoreRequest
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string? Role { get; set; } = "customer";
        //public IFormFile? Avatar { get; set; }
    }
}

