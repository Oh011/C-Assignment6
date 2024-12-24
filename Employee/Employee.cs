using HiringDate;
using Microsoft.VisualBasic;

namespace Employees
{

   public enum  Gender 
    {

        Male,Female
        
        
    }


    public enum Secuirty
    {


        guest=1,
        Devolper=2,
        secretary=3,
        DBA=4,
        securityofficer=5
    }
    public class Employee
    {


        private int Id;

        private string Name;

        private double Salary;

        private HireDate _HireDate;

        private Gender _Gender;

       private Secuirty SecuirtyLevel;


        public int _Id {


            get { return Id; } 
            
            set
            {

                if (ValidId(value)==true)
                    Id = value;



                   
                  
            }    
        }

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public double _salary
        {

            get { return Salary; }

            set
            {

                if (ValidSalary(value) == true)
                {
                    Salary = value;

                }

            }

        }

        public Gender _gender
        {

            get { return this._Gender; }
        }


        public HireDate _hiredate
        {

            get { return this._HireDate; }


            set { this._HireDate = value; }
        }


        public Employee(int id , string name , double salary ,HireDate hire, Gender gender , Secuirty secuirtyLevel)
        {


            if (ValidSalary(id) == true)
            {
                this.Id = id;

            }


            this.Name = name;


            if (ValidSalary(salary) == true)
            {

                    this.Salary = salary;
            }


            this._HireDate = hire;
            this._Gender= gender;
            this.SecuirtyLevel = secuirtyLevel;
              

        }



        private bool ValidId(int id)
        {
            if (id < 0)
            {
                Console.WriteLine("Invalid Id");
                return false;

            }
          
            return true;
        }

        private bool ValidSalary(double salary)
        {
            if (salary < 0)
            {
                Console.WriteLine("Invalid salary");
                return false;

            }

            return true;
        }



        public override string ToString()
        {
            return $" ID : {this.Id} \n Name : {this.Name} \n Salary : {this.Salary:c} \n" +
                $" Gender : {this._Gender} \n Hire Date : {this._HireDate} \n Secuirty Level :{this.SecuirtyLevel}";
        }






    }
}
