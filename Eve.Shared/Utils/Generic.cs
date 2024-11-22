using System.Text;

namespace Eve.Shared.Utils
{
    public static class Generic
    {
        public static string StringToBase64(string str)
        {
            if (str == null || str == "")
                return "";

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }
    }
}
