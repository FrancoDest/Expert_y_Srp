using System;
using System.Text;

namespace Library
{
    public static class Verificador_PhoneNumber
    {
        public static bool ValidPhoneNumber(string phone)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(phone))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgPhoneNumber(string phone)
        {
            string result = "";
            if (!ValidPhoneNumber(phone))
            {
                result = "Unable to schedule appointment, Phone number is required\n";
            }
            return result;
        }
    }
}