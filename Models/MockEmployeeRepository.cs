using System.Collections.Generic;
using System.Linq;

namespace aspnetcoreNewWeb.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                    new Employee(){Id=1,Name="Mary",Email="mary@live.com",Department=Dept.HR},
                    new Employee(){Id=2,Name="aboulmagd",Email="aboulmagd@live.com",Department=Dept.Payroll},
                    new Employee(){Id=3,Name="hany",Email="hany@live.com",Department=Dept.IT}
            };
        }

        public Employee Add(Employee employee)
        {
         employee.Id = _employeeList.Max(e => e.Id) + 1;
        _employeeList.Add(employee);
        return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}