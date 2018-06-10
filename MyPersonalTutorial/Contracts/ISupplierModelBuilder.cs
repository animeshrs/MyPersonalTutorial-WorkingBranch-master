using MyPersonalTutorial.Models;
using System.Collections.Generic;

namespace MyPersonalTutorial.Contracts
{
    public interface ISupplierModelBuilder
    {
        List<SupplierViewModel> GetSupplierList();
    }
}
