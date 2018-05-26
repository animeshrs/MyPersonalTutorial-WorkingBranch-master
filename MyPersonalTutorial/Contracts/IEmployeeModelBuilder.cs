using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalTutorial.Contracts
{
    public interface IEmployeeModelBuilder
    {
        List<Employee> GetEmployees();

        bool AddEmployeeEntity(Employee employee);

        bool EditEmployeeEntity(int employeeId);

        Employee GetEmployeeById(int employeeId);
    }
}
