using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _2020LearCsharp
{
    public class _073AggregateException
    {
        async static Task<string> FectWebPage(string uri)
        {
            var httpClient = new System.Net.Http.HttpClient();
            var response = await httpClient.GetAsync(uri);
            return await response.Content.ReadAsStringAsync();
        }

        public static void executeTest()
        {
            try
            {
                Task<string> getPage = FectWebPage("Invalid Uri");
                getPage.Wait();
                Console.WriteLine(getPage.Result);
            }
            catch (AggregateException ag)
            {
                foreach (Exception e in ag.InnerExceptions)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
