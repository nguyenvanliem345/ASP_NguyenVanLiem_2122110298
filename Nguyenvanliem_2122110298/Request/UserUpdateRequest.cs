namespace Nguyenvanliem_2122110298.Request
{
    public class UserUpdateRequest
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

        public int? UpdatedBy { get; set; }
    }
}
