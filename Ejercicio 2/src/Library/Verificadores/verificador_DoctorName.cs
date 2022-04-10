using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// verifica si el nombre del doctor es válido.
    /// </summary>
    public static class Verificador_DoctorName
    {
        public static bool ValidDoctorName(string doctorName)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(doctorName))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgDoctorName(string doctorName)
        {
            string result = "";
            if (!ValidDoctorName(doctorName))
            {
                result = "Unable to schedule appointment, Doctor name is required\n";
            }
            return result;
        }
    }
}