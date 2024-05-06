using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Domain.Entities
{
    public interface IBaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status? Status { get; set; }
    }
}
