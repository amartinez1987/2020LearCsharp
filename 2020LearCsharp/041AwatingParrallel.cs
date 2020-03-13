using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _041AwatingParrallel
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

        private static async Task<IEnumerable<string>> fechWebPage(string[] url)
        {
            try
            {
                var tasks = new List<Task<string>>();

                foreach (string item in url)
                {
                    tasks.Add(fechWebPage(item));
                }

                return await Task.WhenAll(tasks);
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        public static void executeTest()
        {

            Task<IEnumerable<string>> result = fechWebPage
            (
                new string[]
                {
                    "https://mail.google.com/mail/u/1/#inbox",
                    "http://10.10.131.88:8902/autenticacionLogin.aspx",
                    "https://outlook.live.com/mail/0/inbox"
                }
            );

            foreach (var item in result.Result)
            {
                Console.WriteLine($"result {item.Substring(1,10)}");
            }
           
            Console.ReadKey();

        }
    }
}
