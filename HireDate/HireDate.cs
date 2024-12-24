
namespace HiringDate
{

    public class HireDate
    {

       private int year, month, day;



        public int _year
        {

            get { return year; }

            set {


                if (value <= 0)
                    Console.WriteLine("Invalid Year");

              
                else
                    { year = value; }
            }
        }


        public int _month
        {

            get { return month; }

            set
            {

                if (value <= 0 || value>=12)
                    Console.WriteLine("Invalid Month");

                else
                { month = value; }
            }
        }


        public int _day
        {

            get { return day; }

            set
            {

                if (value <= 0 || value >=31)
                    Console.WriteLine("Invalid Day");

                else
                { day= value; }
            }
        }



        public HireDate()
        {


   

            this.year = 0;
            this.month = 0;
            this.day = 0;
        }
        public HireDate(int year, int month, int day)
        {

            if (year < 1 || (day < 1 || day > 31) || (month <= 0 || month >= 12))
                Console.WriteLine("Invalid Date");


            else
            {
            _year = year;
            _month = month;
            _day = day;

            }
        }


        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }




    }
}
