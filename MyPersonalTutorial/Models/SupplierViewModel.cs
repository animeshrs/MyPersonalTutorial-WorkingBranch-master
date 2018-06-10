using DatabaseLayer;

namespace MyPersonalTutorial.Models
{
    public class SupplierViewModel
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }

        public class Automappings : AutoMapper.Profile
        {
            public Automappings()
            {
                CreateMap<Supplier, SupplierViewModel>();
            }
        }
    }
}