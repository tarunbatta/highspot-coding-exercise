using System;
using System.IO;

namespace highspot.Helper
{
    public static class Utility
    {
        public static string ReadFile(string file)
        {
            string result = string.Empty;

            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read: ", ex);
            }

            return result;
        }

        public static void WriteFile(string file, string text)
        {
            System.IO.File.WriteAllText(file, text);
        }
    }
}