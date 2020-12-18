using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Frustration
{
    public class Program
    {


        public  async static Task Main(string[] args) {

           // ThreadStart thread = new ThreadStart();

            //var words = new[] { "https://www.google.com", "shame", "worry" };

            ////var types = typeof(IEnumerable<string>);

            //var date = new DateTime(2000, 12, 10);
            //date.ToString("d");
            //Console.WriteLine(date);

            var Diagrams = new List<Diagram>()
            {
                new Rect(),
                new Circle()
            };

            foreach (var diag in Diagrams)
            {
                diag.Draw();
            }
            ////Console.WriteLine(GetName());
            //Console.ReadLine();
        }

        private static string GetName() {
            var test = "Taher";
            var result = from s in test.ToLowerInvariant().Split() select s;
            return result.First();
        }
        public static async Task<IEnumerable<(string, bool)>> GetTopItem(IEnumerable<string> words, CancellationToken t) {
            
            var result = from word in words
                         where word.Length > 3
                         orderby word
                         let inter = word.Length > 3
                         select new { name = word, success = inter };

            return await Task.FromResult<IEnumerable<(string, bool)>>(result.Select(x => (x.name, x.success)));

        }

        async static Task<string> GetFirstSuccessfullString(IEnumerable<string> urls) {

            using var httpClient = new HttpClient();

            foreach (var url in urls) {
                try
                {
                    return await httpClient.GetStringAsync(url);
                }
                catch (HttpRequestException exception) {
                    Console.WriteLine($"{exception.Message}");
                }
            }
            throw new HttpRequestException("No url succeeeded");
        }
    }
}
