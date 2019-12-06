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
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(file))
                {
                    // Read the stream to a string, and write the string to the console.
                    result = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read: ", ex);
            }

            return result;
        }
    }
}