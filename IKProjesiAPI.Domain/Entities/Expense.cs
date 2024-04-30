﻿using System;
using IKProjesiAPI.Domain.Enums;

namespace IKProjesiAPI.Domain.Entities
{
	public class Expense
	{
        public int? Id { get; set; }

        public int? PersonelId { get; set; }
        public Personel? Personel { get; set; }

        public ExpenseType? ExpenseType { get; set; }
        public double? TotalExpense { get; set; }
        public MoneyType? MoneyType { get; set; }
        public ApprovalType? ApprovalType { get; set; }
        public DateTime? ResponseTime { get; set; }
        public DateTime? RequestDate { get; set; }
        //public string dosyaeklemepropu { get; set; }
    }
}
