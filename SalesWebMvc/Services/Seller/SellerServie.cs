using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services.Seller
{
    public class SellerServie : ISellerService
    {

        private readonly SalesWebMvcContext _context;

        public SellerServie(SalesWebMvcContext context)
        {
            _context = context;
        }

        public ICollection<SellerModel> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
