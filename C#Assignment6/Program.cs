using Employees;
using HiringDate;
namespace C_Assignment6
{



    internal class Program
    {
        static void Main(string[] args)
        {

            HireDate dbaHireDate = new HireDate( 2020,1,1);  // -> yy mm dd
            HireDate guestHireDate = new HireDate( 2021,6,15);
            HireDate officerHireDate = new HireDate( 2018,9,10);


            Employee[] emparr = new Employee[3];

            emparr[0] = new Employee(1, "omar", 20023.45,guestHireDate ,Gender.Male,
                Secuirty.guest);

            emparr[1] = new Employee(2, "sara", 5077.23, dbaHireDate, Gender.Female, Secuirty.DBA);


            emparr[2] = new Employee(3, "Ahmed", 1234.32, officerHireDate, Gender.Male, Secuirty.securityofficer);









            for (int i = 0; i <emparr.Length; i++)
            {

                Console.WriteLine(emparr[i].ToString());
                Console.WriteLine("---------------------------------------");

            }







        }
    }
}


