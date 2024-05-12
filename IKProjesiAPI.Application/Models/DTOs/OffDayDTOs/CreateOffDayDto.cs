using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.OffDayDTOs
{
    public class CreateOffDayDto
	{
        public int EmployeeId { get; set; }
        public DateTime DayOffStartTime { get; set; }
        public DateTime DayOffEndTime { get; set; }
        public int? DayOffType { get; set; }
        public int? RequestOffDayNumber { get; set; }
    }
}

