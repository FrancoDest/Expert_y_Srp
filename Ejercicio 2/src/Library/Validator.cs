using System;
using System.Text;

namespace Library
{
    public static class Validator
    {
        public static bool ValidStrings(string name, string id, string doctorName, string appointmentPlace, string phoneNumber)
        {
            bool validPlace = Verificador_AppointmentPlace.ValidAppointmentPlace(appointmentPlace);
            bool validId = Verificador_Id.ValidId(id);
            bool validName = Verificador_Name.ValidName(name);
            bool validDoctorName = Verificador_DoctorName.ValidDoctorName(doctorName);
            bool validPhoneNumber = Verificador_PhoneNumber.ValidPhoneNumber(phoneNumber);
            bool result = true;

            if (!validName ^ !validId  ^ !validDoctorName ^ !validPlace ^ !validPhoneNumber)
            {
                result = false;
            }

            return result;
        }
    }
}