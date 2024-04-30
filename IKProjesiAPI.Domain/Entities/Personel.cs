using IKProjesiAPI.Domain.Entities.AppEntities;
using IKProjesiAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProjesiAPI.Domain.Entities
{
    public class Personel:AppUser
    {
        public Personel()
        {
            TakeOffDays = new List<TakeOffDay>();
            AdvancePayments = new List<AdvancePayment>();
            Expenses = new List<Expense>();
        }

        public string? UserName { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        public int? DaysOffNumber { get; set; }
        public double? Payment { get; set; }

        public List<TakeOffDay>? TakeOffDays { get; set; }
        public List<AdvancePayment>? AdvancePayments { get; set; }
        public List<Expense>? Expenses { get; set; }
    }
}
