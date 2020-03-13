using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _040AwaitCacht
    {


        private static async Task<string> fechWebPage(string url)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                return await (httpClient.GetStringAsync(url));
            }
            catch (Exception ex)
            {

                return ex.StackTrace;
            }

        }


        public static void executeTest()
        {

            string result = fechWebPage("https://mail.google.com/mail/u/1/#inbox").Result;
            Console.WriteLine($"result {result}");
            Console.ReadKey();

        }
    }
}
