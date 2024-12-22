using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecordModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public SellerModel Seller { get; set; }

        public SalesRecordModel() 
        {
        }

        public SalesRecordModel( DateTime date, double amount, SaleStatus status, SellerModel seller)
        {
            
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
