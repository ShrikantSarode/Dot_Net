using System.Collections.Generic;
using ModelEx.Models;

namespace ModelEx.Repository
{
    public interface IEmployee
    {
        // Method to get all employees
        List<Employee> GetAllEmployees();

        // Method to get a single employee by ID
        Employee GetEmployee(int id);
    }
}
