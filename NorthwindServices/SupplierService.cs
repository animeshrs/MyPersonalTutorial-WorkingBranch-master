using DatabaseLayer;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindServices
{
    public class SupplierService
    {
        private NorthWindDbContext _context;

        public SupplierService()
        {
            _context = new NorthWindDbContext();
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
    }
}
