using System;
using System.Text;

namespace Library
{
    public static class Generador
    {
        public static bool ValidStrings(string name, string id, string doctorname, string appointmentplace, string phonenumber)
        {
            bool result = true;
            bool validplace = Verificador_AppointmentPlace.AppointmentPlaceisNullOrEmpty(appointmentplace);
            if (validplace == false)
            {
                result = false;
            }
            bool validid = Verificador_Id.IdisNullOrEmpty(id);
            if (validid == false)
            {
                result = false;
            }
            bool validname = Verificador_Name.NameisNullOrEmpty(name);
            if (validname == false)
            {
                result = false;
            }
            bool validdoctorname = Verificador_DoctorName.DoctorNameisNullOrEmpty(doctorname);
            if (validdoctorname == false)
            {
                result = false;
            }
            bool validphonenumber = Verificador_PhoneNumber.PhoneNumberisNullOrEmpty(phonenumber);
            if (validphonenumber == false)
            {
                result = false;
            }
            return result;
        }
        public static string generador(string name, string id, string phonenumber, string appointmentplace, string doctorname)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            bool result = ValidStrings(name, id, phonenumber, appointmentplace, doctorname);
            if (result)
            {
                string msg_name = Verificador_Name.MsgName(name);
                stringBuilder.Append(msg_name);
                string msg_id = Verificador_Id.MsgId(name);
                stringBuilder.Append(msg_id);
                string msg_phone = Verificador_PhoneNumber.MsgPhoneNumber(name);
                stringBuilder.Append(msg_phone);
                string msg_place = Verificador_AppointmentPlace.MsgAppointmentPlace(name);
                stringBuilder.Append(msg_place);
                string msg_doctor = Verificador_DoctorName.MsgDoctorName(name);
                stringBuilder.Append(msg_doctor);
                stringBuilder.Append("Appoinment Scheduled");
            }
            return stringBuilder.ToString();
        }
    }
}