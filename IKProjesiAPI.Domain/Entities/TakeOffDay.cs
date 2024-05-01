using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Domain.Entities
{
	public class TakeOffDay
	{
        public int? Id { get; set; }

        public int? EmployeeId { get; set; }
		public Employee? Employee { get; set; }

		public ApprovalType? ApprovalType { get; set; }
		public DateTime? RequestTime { get; set; }
		public DateTime? DayOffStartTime { get; set; }
        public DateTime? DayOffEndTime { get; set; }
		public int? DayNumber { get; set; }
		public DateTime? ResponseTime { get; set; }
		public DayOffType? DayOffType { get; set; }
	}
}

