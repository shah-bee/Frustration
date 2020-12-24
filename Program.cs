using DesignPatterns;
using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.FactoryDesignPattern;
using DesignPatterns.Strategy;
using Practise.DesignPattern.Frsutration;
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

        public static void Main(string[] args)
        {
            #region SingleTon
            //Parallel.Invoke(
            //    () => First(),
            //    () => Second());

            //SingletonForLearning singleton = SingletonForLearning.GetInstance;
            //int x = 23;
            #endregion

            #region Factory Design Pattern
            //var Vehicle = Factory.GetVehicle("car");
            //Vehicle.Details();
            //var car = (Car)Vehicle;
            //car.CarColor();
            #endregion

            //Console.ReadLine();

            #region AbstractFactory Design Pattern
            //IComputerFactory factory = new DellFactory();
            //EmployeeSystemManager manager = new EmployeeSystemManager(factory);
            //Console.WriteLine(manager.GetSystemDetails());
            #endregion

            #region Events & Delegates
            //var mailService = new MailService();

            //Video myVideo = new Video { MyVideo = "My video" };
            //VideoEncode encoder = new VideoEncode();
            //encoder.VideoEncoded += mailService.SendMail; //subsribers
            //encoder.VideoEncoded += Encoder_VideoEncoded;

            //encoder.SelectCandiate(Crtieria, "c");
            //encoder.Encode(myVideo);

            #endregion

            #region Strategy Design Pattern

            //  In Strategy pattern, a class behavior or its algorithm can be changed at run time.
            //  This type of design pattern comes under behavior pattern.

            //  In Strategy pattern, we create objects which represent various strategies and a context object whose behavior varies as per its strategy object.
            //  The strategy object changes the executing algorithm of the context object.

            var context = new Context(new Add());
            Console.WriteLine(context.ExecuteStrategy(12, 34));

            #endregion

            #region Adaptor Design Pattern

            var mediaPlay = new Adaptee(new AdvancedMediaPlayer());
            mediaPlay.PlayMp4();

            #endregion

        }

        public static bool Crtieria(string citeria)
        {
            return true;
        }

        private static void Encoder_VideoEncoded(object source, EventArgs args)
        {
            throw new NotImplementedException();
        }

        private static void First()
        {
            var singleton = SingletonForLearning.GetInstance;
            singleton.PrintDetails();
        }

        private static void Second()
        {
            var singleton = SingletonForLearning.GetInstance;
            singleton.PrintDetails();
        }

        private static string GetName()
        {
            var test = "Taher";
            var result = from s in test.ToLowerInvariant().Split() select s;
            return result.First();
        }
        public static async Task<IEnumerable<(string, bool)>> GetTopItem(IEnumerable<string> words, CancellationToken t)
        {

            var result = from word in words
                         where word.Length > 3
                         orderby word
                         let inter = word.Length > 3
                         select new { name = word, success = inter };

            return await Task.FromResult<IEnumerable<(string, bool)>>(result.Select(x => (x.name, x.success)));

        }

        async static Task<string> GetFirstSuccessfullString(IEnumerable<string> urls)
        {

            using var httpClient = new HttpClient();

            foreach (var url in urls)
            {
                try
                {
                    return await httpClient.GetStringAsync(url);
                }
                catch (HttpRequestException exception)
                {
                    Console.WriteLine($"{exception.Message}");
                }
            }
            throw new HttpRequestException("No url succeeeded");
        }
    }
}
