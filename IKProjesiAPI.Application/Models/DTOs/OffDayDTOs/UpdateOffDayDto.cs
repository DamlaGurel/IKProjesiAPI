﻿using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Application.Models.DTOs.OffDayDTOs
{
    public class UpdateOffDayDto
	{
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string? EmployeeFullName { get; set; }
        public DateTime DayOffStartTime { get; set; }
        public DateTime DayOffEndTime { get; set; }
        public int? DayOffType { get; set; }
        public int? AnnualOffDayNumber { get; set; }
        public int ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }

    }
}

