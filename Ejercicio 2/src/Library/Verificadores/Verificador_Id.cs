using System;
using System.Text;

namespace Library
{
    public static class Verificador_Id
    {
        public static bool ValidId(string id)
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(id))
            {
                isValid = false;
            }
            return isValid;
        }
        public static string MsgId(string id)
        {
            string result = "";
            if (!ValidId(id))
            {
                result = "Unable to schedule appointment, id is required\n";
            }
            return result;
        }
    }
}