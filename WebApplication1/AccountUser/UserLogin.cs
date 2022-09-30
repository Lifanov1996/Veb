using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.AccountUser
{
    public class UserLogin
    {
        [Required, MaxLength(20)]
        public string LoginUser { get; set; }

        [Required, DataType(DataType.Password)]
        public string PasswordUser { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
