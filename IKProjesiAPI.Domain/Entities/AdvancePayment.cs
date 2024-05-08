using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Domain.Entities
{
	public class AdvancePayment : IBaseEmployee
	{
        public int? Id { get; set; }
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        //public double? Payment { get; set; }

        public AdvanceType? AdvanceType { get; set; }
        public double? TotalAdvance { get; set; }
        public MoneyType? MoneyType { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Description { get; set; }

    }
}

