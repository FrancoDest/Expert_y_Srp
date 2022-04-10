using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// Esta clase se encarga de generar un string con el mensaje final.
    /// </summary>
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            bool result = Validator.ValidStrings(name, id, phoneNumber, appointmentPlace, doctorName);

            string msg_name = Verificador_Name.MsgName(name);
            stringBuilder.Append(msg_name);

            string msg_id = Verificador_Id.MsgId(id);
            stringBuilder.Append(msg_id);

            string msg_phone = Verificador_PhoneNumber.MsgPhoneNumber(phoneNumber);
            stringBuilder.Append(msg_phone);

            string msg_place = Verificador_AppointmentPlace.MsgAppointmentPlace(appointmentPlace);
            stringBuilder.Append(msg_place);

            string msg_doctor = Verificador_DoctorName.MsgDoctorName(doctorName);
            stringBuilder.Append(msg_doctor);

            if (result)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }
            string Text = stringBuilder.ToString();
            return Text;
        }


    }
}
