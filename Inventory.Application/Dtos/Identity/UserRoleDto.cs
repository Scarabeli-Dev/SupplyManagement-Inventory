namespace Inventory.Application.Dtos.Identity
{
    public class UserRoleDto
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public UserDto User { get; set; }
        public RoleDto Role { get; set; }
    }
}
