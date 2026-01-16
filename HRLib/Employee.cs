namespace HRLib
{
    public abstract class Employee
    {
		private string name;
		static int CountdownEvent=101;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string address;

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
		private int employeeNo;

		public int EmployeeNo
		{
			get { return employeeNo; }
			set { employeeNo = value; }
		}

		public Employee()
		{
			EmployeeNo = CountdownEvent;
			CountdownEvent++;
		}
		public Employee(string name, string address):this()
		{
			this.name = name;
			this.address = address;
		}
		public abstract double CalculateSalary();
	}
}
