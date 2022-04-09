using System;
using System.Text;

namespace Library
{
    public static class Verificador_Name
    {
        public static bool NameisNullOrEmpty(string name)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(name))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgName(string client_name)
        {
            string result = "";
            if (string.IsNullOrEmpty(client_name))
            {
                result = "Unable to schedule appointment, Name is required\n";
            }
            return result;
        }
    }
}