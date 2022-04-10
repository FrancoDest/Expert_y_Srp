using System;
using System.Text;

namespace Library
{
    /// <summary>
    /// verifica si el nombre es válido.
    /// </summary>
    public static class Verificador_Name
    {
        public static bool ValidName(string client_name)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(client_name))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgName(string client_name)
        {
            string result = "";
            if (!ValidName(client_name))
            {
                result = "Unable to schedule appointment, Name is required\n";
            }
            return result;
        }
    }
}