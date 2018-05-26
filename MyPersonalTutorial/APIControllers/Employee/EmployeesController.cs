using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DatabaseLayer;
using AutoMapper;
using MyPersonalTutorial.Models;
using MyPersonalTutorial.Contracts;

namespace MyPersonalTutorial.APIControllers.Employees
{
    public class EmployeesController : ApiController
    {
        public readonly IEmployeeModelBuilder _iEmployeeModelBuilder;

        public EmployeesController(IEmployeeModelBuilder iEmployeeModelBuilder)
        {
            _iEmployeeModelBuilder = iEmployeeModelBuilder;
        }

        public List<EmployeeViewModel> GetEmployees()
        {
            var listOfEmployees = _iEmployeeModelBuilder.GetEmployees();
            var listOfEmployeeVms = listOfEmployees.Select(Mapper.Map<EmployeeViewModel>).ToList();
            return listOfEmployeeVms;
        }

        [HttpPost]
        public EmployeeViewModel AddEmployee(EmployeeViewModel viewModel)
        {
            var employeeEntity = Mapper.Map<Employee>(viewModel);
            var result = _iEmployeeModelBuilder.AddEmployeeEntity(employeeEntity);
            if (result)
                return viewModel;
            return new EmployeeViewModel();
        }

        public EmployeeViewModel EditEmployee(int employeeId)
        {
            return new EmployeeViewModel();
        }

        //public EmployeeViewModel GetEmployeeById(int employeeId)
        //{
        //    var employee = _iEmployeeModelBuilder.GetEmployeeById(employeeId);
        //    var employeeVm = Mapper.Map<EmployeeViewModel>(employee);
        //    return employeeVm;
        //}
    }
}
