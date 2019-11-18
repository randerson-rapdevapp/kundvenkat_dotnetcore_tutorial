using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Mvc.Models
{
	public class MockEmployeeRepository : IEmployeeRepository
	{
		private List<Employee> _employeeList;

		public MockEmployeeRepository()
		{
			_employeeList = new List<Employee>
			{
				new Employee() { id=1, Name="Ryan", Department = "HR", Email="ryan@gmail.com"},
				new Employee() { id = 2, Name = "Michelle", Department = "IT", Email="michelle@gmail.com" },
				new Employee() { id = 3, Name= "Tammy", Department = "Sales", Email="tammy@gmail.com" }
			};
		}

		public Employee GetEmployee(int id)
		{
			return _employeeList.FirstOrDefault(f => f.id.Equals(id));
		}
	}
}
