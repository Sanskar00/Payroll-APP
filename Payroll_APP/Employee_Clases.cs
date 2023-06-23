using System;
using System.Collections;
namespace ConsoleApplication1
{


    public abstract class Employee
    {
        public static int static_emp_id = 0;
        public static List<Employee> EmpList = new();
        public static ArrayList ResultList = new();
        public int emp_id;
        public string emp_name;
        public double basic_salary;

        public Employee(string emp_name, int basic_salary)
        {
            static_emp_id++;
            emp_id = static_emp_id;
            this.emp_name = emp_name;
            this.basic_salary = basic_salary;
        }

        public static void AddEmpToEmpList(Employee obj) {
            EmpList.Add(obj);
            Hashtable emp = new Hashtable();
            emp.Add("emp_name", obj.emp_name);
            emp.Add("emp_id", obj.emp_id);
            emp.Add("basic_salary", obj.basic_salary);
            ResultList.Add(emp);


        }

        public double TaxOnSalary()
        {
            return basic_salary * 20 / 100;
        }

        public abstract double ComputeSalary();

    }

    public class Programmer : Employee
    {
        protected double hra = 5;

        public Programmer(string emp_name, int basic_salary) : base(emp_name, basic_salary)
        {

        }

        public override double ComputeSalary()
        {
            double salary = basic_salary - TaxOnSalary() + (basic_salary * hra / 100);
            return salary;
        }

    }

    public class Manager : Employee
    {
        protected double bonus = 10;

        public Manager(string emp_name, int basic_salary) : base(emp_name, basic_salary)
        {

        }

        public override double ComputeSalary()
        {
            double salary = basic_salary - TaxOnSalary() + (basic_salary * bonus / 100);
            return salary;
        }

    }

    public class SalesExec : Employee
    {
        protected double travelAllowance = 15;

        public SalesExec(string emp_name, int basic_salary) : base(emp_name, basic_salary)
        {

        }

        public override double ComputeSalary()
        {
            double salary = basic_salary - TaxOnSalary() + (basic_salary * travelAllowance / 100);
            return salary;
        }

    }


}

