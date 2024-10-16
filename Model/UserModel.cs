using Microsoft.AspNetCore.Identity;

namespace UserService.Model
{
    public class UserModel : IdentityUser
    {
        public string Name { get; set; }
    }
}
