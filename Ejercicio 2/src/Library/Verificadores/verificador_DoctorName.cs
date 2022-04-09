using System;
using System.Text;

namespace Library
{
    public static class Verificador_DoctorName
    {
        public static bool DoctorNameisNullOrEmpty(string doctorname)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(doctorname))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgDoctorName(string doctor_name)
        {
            string result = "";
            if (string.IsNullOrEmpty(doctor_name))
            {
                result = "Unable to schedule appointment, Doctor name is required\n";
            }
            return result;
        }
    }
}