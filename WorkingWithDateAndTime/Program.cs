using System;

namespace WorkingWithDateAndTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //    Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddDays(-3).ToShortDateString());
            //   Console.WriteLine(myValue.AddHours(3).ToShortTimeString() );
            //Console.WriteLine(myValue.Month.ToString());

            // DateTime myBirthday = new DateTime(2001, 6, 12); 
            //Console.WriteLine(myBirthday.ToShortDateString()); 
            DateTime myBirthday = DateTime.Parse("6/12/2001");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
