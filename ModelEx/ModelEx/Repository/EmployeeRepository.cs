﻿using ModelEx.Models;
using System.Collections.Generic;
using System.Linq;

namespace ModelEx.Repository
{
    public class EmployeeRepository : IEmployee
    {
        // Get all employees from the "database"
        public List<Employee> GetAllEmployees()
        {
            return Database();
        }

        // Get a single employee by their ID
        public Employee GetEmployee(int id)
        {
            return Database().Where(x => x.Id == id).FirstOrDefault();  // Simplified query
        }

        // Simulated database of employees
        private List<Employee> Database()
        {
            return new List<Employee>
            {
                new Employee { Id = 101, Name = "Shrikant", Gender = "Male", Level = 3 },
                new Employee { Id = 103, Name = "Nora", Gender = "Female", Level = 2 },
                new Employee { Id = 104, Name = "Kiara", Gender = "Female", Level = 3 },
                new Employee { Id = 102, Name = "Karishma", Gender = "Female", Level = 1 }
            };
        }
    }
}