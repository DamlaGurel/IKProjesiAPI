using IKProjesiAPI.Domain.Entities.AppEntities;

namespace IKProjesiAPI.Domain.Entities
{
    public class CompanyManager:AppUser
    {
        public CompanyManager()
        {
            Employees = new List<Employee>();
        }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public double? Payment { get; set; }

    }
}
