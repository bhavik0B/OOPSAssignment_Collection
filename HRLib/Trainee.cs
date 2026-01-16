using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class Trainee:Employee
    {
		private int noOfDays;

		public int NoOfDays
		{
			get { return noOfDays; }
			set { noOfDays = value; }
		}
		private double ratePerDay;

		public double RatePerDay
		{
			get { return ratePerDay; }
			set { ratePerDay = value; }
		}
		public Trainee():base()
		{
			this.noOfDays = 0;
			this.ratePerDay = 0.0;
		}
		public Trainee(int noOfDays, double ratePerDay,string name,string address):base(name,address)
		{
			this.noOfDays= NoOfDays;
			this.ratePerDay = RatePerDay;
		}

        public sealed override double CalculateSalary()
        {
			return NoOfDays * RatePerDay;
        }

        public override string ToString()
        {
			string information = $"Name = {Name} Address = {Address} No of Days = {NoOfDays} Rate per day = {RatePerDay}";
			return information;
		}

    }
}
