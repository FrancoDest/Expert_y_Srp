using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("", "UWU", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "xd");
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = AppointmentService.CreateAppointment("Ralf Manson", "UWU", "", DateTime.Now, "Queen Street", "xd");
            Console.WriteLine(appointmentResult3);

            string appointmentResult4 = AppointmentService.CreateAppointment("Ralf Manson", "UWU", "5555-555-555", DateTime.Now, "", "xd");
            Console.WriteLine(appointmentResult4);

            string appointmentResult5 = AppointmentService.CreateAppointment("Ralf Manson", "UWU", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult5);

            string appointmentResult6 = AppointmentService.CreateAppointment("Ralf Manson", "UWU", "5555-555-555", DateTime.Now, "Queen Street", "xd");
            Console.WriteLine(appointmentResult6);
        }
    }
}
