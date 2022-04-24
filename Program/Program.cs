
using System;

namespace DateFormat
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat2(testDate));
        }

        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        public static String ChangeFormat_2(String year) 
        {
            return year.Substring(3, 2) + "." + year.Substring(0, 2) + "." + year.Substring(6);
        }
        
    }
}