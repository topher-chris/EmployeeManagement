﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
   {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@test.com"},
            new Employee() { Id = 2, Name = "James", Department = "HR", Email = "james@test.com" },
            new Employee() { Id = 3, Name = "Don", Department = "IT", Email = "don@test.com" }
            };
        }
            public Employee GetEmployee(int Id)
            {
                return _employeeList.FirstOrDefault(e => e.Id ==Id);
            }
        }
    }

