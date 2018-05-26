using MyPersonalTutorial.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseLayer;
using NorthwindServices;

namespace MyPersonalTutorial.ModelBuilders
{
    public class EmployeeModelBuilder : IEmployeeModelBuilder
    {
        private EmployeeService _service;

        public EmployeeModelBuilder()
        {
            _service = new EmployeeService();
        }

        public List<Employee> GetEmployees()
        {
            var employees = _service.GetAllEmployees();
            return employees;
        }

        public bool AddEmployeeEntity(Employee employee)
        {
            return _service.AddEmployee(employee) ? true : false;
        }

        public bool EditEmployeeEntity(int employeeId)
        {
            return false;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            var employee = _service.GetById(employeeId);
            return employee;
        }
    }
}