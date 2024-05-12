
namespace IKProjesiAPI.Application.Models.DTOs.UserDTOs
{
    public class ChangePasswordDto
    {
        public string TemporaryPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
