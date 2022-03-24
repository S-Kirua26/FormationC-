using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {

            PhoneBook phone = new PhoneBook();
            phone.AddPhoneNumber("0606060606", "Michel");
            phone.AddPhoneNumber("0634200025", "Marc");
            phone.ContainsPhoneContact("0634200025");
            phone.PhoneContact("0634200025");
            phone.DisplayPhoneBook();
            //phone.DeletePhoneNumber("0322339999");
            phone.DeletePhoneNumber("0606060606");
            ////////////////////////////////////////////////////////////////////////////////
            BusinessSchedule reu = new BusinessSchedule();
            DateTime date1 = new DateTime(2022, 5, 1, 16, 0, 0);
            DateTime date2 = new DateTime(2022, 9, 12, 13, 25, 0);
            TimeSpan duration = new TimeSpan(0, 3, 0, 0);
            reu.AddBusinessMeeting(DateTime.Now, duration);
            reu.AddBusinessMeeting(date1, duration);
            reu.AddBusinessMeeting(date2, duration);

            reu.DisplayMeetings();
            // Keep the console window open
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
