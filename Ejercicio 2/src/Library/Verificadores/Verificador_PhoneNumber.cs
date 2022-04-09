using System;
using System.Text;

namespace Library
{
    public static class Verificador_PhoneNumber
    {
        public static bool PhoneNumberisNullOrEmpty(string phone)
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
            if (string.IsNullOrEmpty(phone))
            {
                result = "Unable to schedule appointment, phone number is required\n";
            }
            return result;
        }
    }
}