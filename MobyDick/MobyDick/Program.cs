using MobyDick.Service;
using MobyDick.Service.FileReader;
using System;
using System.Linq;

namespace MobyDick
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Top100MostccurringWords top = new Top100MostccurringWords();
            ////TextFileReader txt = new TextFileReader();
            //var arr = top.GetAllFrequencyWordsExcludingStopWatchWords();
            //foreach (var r in arr)
            //{
            //    Console.WriteLine(r);
            //}



            Top100MostccurringWords top = new Top100MostccurringWords();
            var result = top.Top100FrequencyWords().OrderByDescending(x => x.Value).Take(100);

            Console.WriteLine("Num     Word      Frequency");
            Console.WriteLine("---------------------------------------");
            int counter = 1;
            foreach (var item in result)
            {
                Console.WriteLine("{0,2}    {1,-8}    {2,7}", counter++, item.Key, item.Value);
            }
            Console.ReadKey();

        }

        
    }
}
