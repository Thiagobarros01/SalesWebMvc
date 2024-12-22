using SalesWebMvc.Models;

namespace SalesWebMvc.Services.Seller
{
    public interface ISellerService
    {
        public ICollection<SellerModel> FindAll();
    }
}
