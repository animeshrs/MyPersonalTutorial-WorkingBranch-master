using MyPersonalTutorial.Contracts;
using MyPersonalTutorial.Models;
using NorthwindServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyPersonalTutorial.APIControllers.Supplier
{
    public class SupplierController : ApiController
    {
        private readonly ISupplierModelBuilder _iSupplierModelBuilder;

        public SupplierController(ISupplierModelBuilder iSupplierModelBuilder)
        {
            _iSupplierModelBuilder = iSupplierModelBuilder;
        }

        public List<SupplierViewModel> GetAllSupplierList()
        {
            var suppliers = _iSupplierModelBuilder.GetSupplierList();
            return suppliers;
        }
    }
}
