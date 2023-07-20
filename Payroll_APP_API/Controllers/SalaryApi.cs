using System;
using System.Collections;
using ConsoleApplication1;
using Microsoft.AspNetCore.Mvc;
namespace Payroll_APP.API.Controllers
{
    [Route("api/employee/salary")]
    [ApiController]
    public class SalaryApi : ControllerBase
    {
        [HttpGet]
		public ArrayList GetSalary()
		{
            ArrayList salary_list = new ArrayList();//it is salary list new nnn
            foreach(Employee obj in Employee.EmpList) {
                Hashtable emp = new Hashtable();
                emp.Add("emp_name",obj.emp_name);
                emp.Add("salary", obj.ComputeSalary());
                salary_list.Add(emp);
            }

            return salary_list;
		}
	}
}

