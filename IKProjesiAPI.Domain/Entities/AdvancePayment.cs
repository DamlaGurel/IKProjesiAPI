﻿using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Domain.Entities.AppEntities
{
	public class AdvancePayment
	{
        public int? Id { get; set; }
        public int? PersonelId { get; set; }
        public Personel? Personel { get; set; }

        public AdvanceType? AdvanceType { get; set; }
        public double? TotalAdvance { get; set; }
        public MoneyType? MoneyType { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        public string? Description { get; set; }

    }
}
