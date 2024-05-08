using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.OffDayDTOs
{
	public class ApprovalOffDayDto
	{
        public int? Id { get; set; }
        public int ApprovalType { get; set; }
        public DateTime? RequestTime { get; set; }
        public DateTime? DayOffStartTime { get; set; }
        public DateTime? DayOffEndTime { get; set; }
        public int? DayNumber { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DayOffType? DayOffType { get; set; }
        public int? DaysOffNumber { get; set; }

        public int? EmployeeId { get; set; }
        public string? EmployeeFullName { get; set; }
    }
}

