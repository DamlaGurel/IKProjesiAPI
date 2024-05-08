
namespace IKProjesiAPI.Application.Models.DTOs.SiteManagerDTOs
{
    public class SiteManagerUpdateDto
    {
        public int Id { get; set; }
        public string? ImageString { get; set; }
        public byte[]? ImageBytes { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
