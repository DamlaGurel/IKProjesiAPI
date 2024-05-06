using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.EmployeeDTOs
{
	public class CreateTakeDayOffDto
	{
        public DateTime DayOffStartTime { get; set; }
        public DateTime DayOffEndTime { get; set; }
        public int? DayOffType { get; set; }
        public int? RequestOffDayNumber { get; set; }
    }
}

