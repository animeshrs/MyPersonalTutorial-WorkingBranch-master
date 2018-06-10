using AutoMapper;
using MyPersonalTutorial.Contracts;
using MyPersonalTutorial.Models;
using NorthwindServices;
using System.Collections.Generic;
using System.Linq;

namespace MyPersonalTutorial.ModelBuilders
{
    public class SupplierModelBuilder : ISupplierModelBuilder
    {
        private readonly SupplierService _supplierService;

        public SupplierModelBuilder()
        {
            _supplierService = SupplierService.GetInstance;
        }

        public List<SupplierViewModel> GetSupplierList()
        {
            var result = _supplierService.GetAllSuppliers();
            var resultVm = result.Select(Mapper.Map<SupplierViewModel>).ToList();
            return resultVm;
        }
    }
}