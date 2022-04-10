using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// verifica si el lugar de la consulta es válido.
    /// </summary>
    public static class Verificador_AppointmentPlace
    {
        public static bool ValidAppointmentPlace(string place)
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
            if (!ValidAppointmentPlace(place))
            {
                result = "Unable to schedule appointment, Appointment place is required\n";
            }
            return result;
        }
    }
}