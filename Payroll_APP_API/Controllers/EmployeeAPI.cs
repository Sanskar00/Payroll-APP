using System;
using System.Collections;
using ConsoleApplication1;
using Microsoft.AspNetCore.Mvc;

namespace Payroll_APP_API.Controllers
{
	[Route("api/employee")]
	[ApiController]
    public class PayrollAPI : ControllerBase
	{
  

        [HttpPost]
		public  ArrayList AddEmployee() {
			string emp_name = Request.Form["emp_name"];// emp name coming in request
			string form_salary = Request.Form["basic_salary"];
			string emp_type = Request.Form["emp_type"];// type of employee coming in request
            int basic_salary = int.Parse(form_salary);//basic salary comint in request
            if (emp_type == "Prog" && emp_name != null)
			{
				Programmer prog = new Programmer(emp_name, basic_salary);
				Employee emp = prog;
				Employee.AddEmpToEmpList(emp);

			}else if (emp_type == "Man" && emp_name != null)
            {
                Manager man = new Manager(emp_name, basic_salary);
                Employee emp = man;
                Employee.AddEmpToEmpList(emp);

			}
			else if (emp_type == "Sales" && emp_name != null)
            {
				SalesExec sales = new SalesExec(emp_name, basic_salary);
				Employee emp = sales;
				Employee.AddEmpToEmpList(emp);

			}


            //Employee.AddEmpEmpList(); 

            return Employee.ResultList;
		}

		[HttpGet]
		public ArrayList GetEmployee()
		{
			return Employee.ResultList;
		}		
	}



	
}

