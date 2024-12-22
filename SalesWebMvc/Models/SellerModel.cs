namespace SalesWebMvc.Models
{
    public class SellerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public DepartmentModel Department { get; set; }
        public ICollection<SalesRecordModel> Sales { get; set; } = new List<SalesRecordModel>();

        public SellerModel()
        {

        }

        public SellerModel(string name, string email, DateTime birthDate, double baseSalary, DepartmentModel department)
        {
           
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecordModel sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecordModel sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(s => s.Date >= initial && s.Date <= final).Sum(s=>s.Amount);
        }
    }
}
