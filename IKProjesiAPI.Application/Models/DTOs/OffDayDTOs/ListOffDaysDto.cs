using System;
using IKProjesiAPI.Domain.Entities;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.OffDayDTOs
{
    public class ListOffDaysDto
	{
        public int? ApprovalType { get; set; }
        public DateTime? RequestTime { get; set; }
        public DateTime? DayOffStartTime { get; set; }
        public DateTime? DayOffEndTime { get; set; }
        public int? RequestOffDayNumber { get; set; }
        public DateTime? ResponseTime { get; set; }
        public int? DayOffType { get; set; }

    }
}

