using IKProjesiAPI.Domain.Entities.AppEntities;

namespace IKProjesiAPI.Domain.Entities
{
    public class Employee : AppUser
    {
        public Employee()
        {
            TakeOffDays = new List<TakeOffDay>();
            AdvancePayments = new List<AdvancePayment>();
            Expenses = new List<Expense>();
        }
        public string? UserName { get; set; }
        public int? CompanyManagerId { get; set; }
        public CompanyManager? CompanyManager { get; set; }
        public int? DaysOffNumber { get; set; }
        public double? Payment { get; set; }

        public List<TakeOffDay>? TakeOffDays { get; set; }
        public List<AdvancePayment>? AdvancePayments { get; set; }
        public List<Expense>? Expenses { get; set; }
    }
}
