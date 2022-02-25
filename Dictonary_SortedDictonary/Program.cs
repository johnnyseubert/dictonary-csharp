using System;
using System.Collections.Generic;

namespace Dictonary_SortedDictonary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            try
            {
                cookies["user"] = "Maria";
                cookies["email"] = "maria@gmail.com";
                cookies["phone"] = "99219-6789";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Size: " + cookies.Count);
            
            Console.WriteLine("All Cookies: ");
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
}