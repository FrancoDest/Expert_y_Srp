using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /// <summary>
        /// Este método tiene varias responsabilidades, las cuales consisten en generar una string con un mensaje en consola, y verificar que los datos ingresados no sean nulos. Para que la clase cumpla con SRP, la creación del mensaje y cada verificación de los datos ingresados deeberían realizarse por separado.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="date"></param>
        /// <param name="appoinmentPlace"></param>
        /// <param name="doctorName"></param>
        /// <returns></returns>
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appointment place is required\n");
                isValid = false;
            }
            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appointment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
