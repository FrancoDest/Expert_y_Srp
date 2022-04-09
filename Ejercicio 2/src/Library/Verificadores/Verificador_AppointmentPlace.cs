using System;
using System.Text;

namespace Library
{
    public static class Verificador_AppointmentPlace
    {
        public static bool AppointmentPlaceisNullOrEmpty(string place)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(place))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgAppointmentPlace(string place)
        {
            string result = "";
            if (string.IsNullOrEmpty(place))
            {
                result = "Unable to schedule appointment, Appointment place is required\n";
            }
            return result;
        }
    }
}