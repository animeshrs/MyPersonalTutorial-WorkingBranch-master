using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindServices
{
    public class EmployeeService
    {
        private NorthWindDbContext _context;
        public EmployeeService()
        {
            _context = new NorthWindDbContext();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public bool AddEmployee(Employee employeeEntityToAdd)
        {
            if (employeeEntityToAdd != null)
            {
                _context.Employees.Add(employeeEntityToAdd);
                return true;
            }
            return false;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Employee GetById(int employeeId)
        {
            var employee = _context.Employees.Find(employeeId);
            return employee;
        }
    }
}
