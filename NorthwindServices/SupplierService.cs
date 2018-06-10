using DatabaseLayer;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindServices
{
    public sealed class SupplierService
    {
        private NorthWindDbContext _context;
        private static SupplierService _instance;

        private SupplierService()
        {
            _context = new NorthWindDbContext();
        }


        // singleton design pattern
        public static SupplierService GetInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new SupplierService();
                return _instance;
            }
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
    }
}
