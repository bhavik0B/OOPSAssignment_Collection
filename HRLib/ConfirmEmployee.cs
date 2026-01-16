using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class ConfirmEmployee:Employee
    {
		private double basic;

		public double Basic
		{
			get { return basic; }
			set {
				if (value < 5000.0)
				{
					throw new BasicSalaryException("salary less than 5000");
				}
					basic = value;
			}
		}
		private string designation;

		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}
		public ConfirmEmployee() : base()
		{
			this.basic = 0.0;
			this.designation = "employee";
		}
		public ConfirmEmployee(double basic, string designation,string name,string address):base(name,address)
		{
			this.Basic=basic;
			this.designation=designation;
		}
        public sealed override double CalculateSalary()
        {
			double hra = 0.0;
			double conv=0.0;
			double pf = 0.0;
			if (Basic >= 30000)
			{
				hra = 0.3 * Basic;
				conv = 0.3 * Basic;
				pf = 0.1 * Basic;
			}
            else if (Basic >= 20000 && Basic<30000)
            {
                hra = 0.2 * Basic;
                conv = 0.2 * Basic;
                pf = 0.1 * Basic;
            }
			else
			{
                hra = 0.1 * Basic;
                conv = 0.1 * Basic;
                pf = 0.1 * Basic;
            }
			double netSalary = Basic + hra + conv - pf;
			return netSalary;

        }
        public override string ToString()
        {
			string obj = $"EmployeeNumber = {EmployeeNo} Employee Name = {Name} Employee address = {Address} Employee Basic Salary = {Basic} Employee Designation = {Designation}";
			return obj;
        }

    }
}
