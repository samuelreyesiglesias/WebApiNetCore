using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleAppClient
{
    class Program
    {
        public static Task<HttpResponseMessage> GetData()
        {
            HttpClient ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("http://localhost:56612/api/home/");
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
            var data = ApiClient.GetAsync("index");
            return data;
        }
        static void Main(string[] args)
        {
            HttpResponseMessage Response = GetData().Result;

            if (Response.IsSuccessStatusCode)
            {
                Console.WriteLine("Susscessfull client request");
                string StringDataResult = Response.Content.ReadAsStringAsync().Result;
                Console.WriteLine($"We get this data:{StringDataResult}");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
