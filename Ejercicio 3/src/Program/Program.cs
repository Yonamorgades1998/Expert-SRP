using System;
using Library;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appoint = AppointmentService.CreateAppointment("Yonatan", "53375351", "098239339", DateTime.Parse("2020-02-02"), "Montevideo", "Dr.Strange");
            Console.WriteLine(appoint);
        }
    }
}
