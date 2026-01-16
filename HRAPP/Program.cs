using HRLib;
namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //ConfirmEmployee confirmEmployee = new ConfirmEmployee(30000,"Analyst","Jack","Chandrapur");
           // ConfirmEmployee confirmEmployee1 = new ConfirmEmployee(12000, "Analyst", "Bhavik", "Chandrapur");
            ConfirmEmployee confirmEmployee2;
            try
            {
                confirmEmployee2 = new ConfirmEmployee(4000, "Analyst", "Aman", "Chandrapur");  
                Console.WriteLine(confirmEmployee2);

            }
            catch (BasicSalaryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Console.WriteLine(confirmEmployee);
            //Console.WriteLine(confirmEmployee1);
            //Console.WriteLine(confirmEmployee.CalculateSalary());
            Trainee trainee = new Trainee(5,2.20,"bhavik","Chandrapur");
            Console.WriteLine(trainee);
            Console.WriteLine(trainee.CalculateSalary());


        }
    }
}
