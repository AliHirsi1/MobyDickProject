using MobyDick.Service.FileReader;
using MobyDick.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyDick.Service
{
    /*
  * Author: Ali H
  * 
  * This class is designed to return 100  most frequency occurring that is not in
  * the stop-watch words 
  * out stop watch words and return 100 frequency occurring words  
  * 
  */
    public class Top100MostccurringWords : IFrequencyCount
    {
        TextFileReader textReader = new TextFileReader();
        public List<string> GetAllFrequencyWordsExcludingStopWatchWords()
        {
            List<string> allFreq = new List<string>();
            var mobyDickList = textReader.MobyDickReader();
            foreach (var item in mobyDickList)
            {
                if (!IsInStopWords(item))
                {
                    allFreq.Add(item);
                }
            }

            return allFreq;
        }

        public bool IsInStopWords(string word)
        {
            var stopWatchList = textReader.StopWordsReader();
            foreach (var item in stopWatchList)
            {
                if (item.ToLower() == word.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public Dictionary<string, int> Top100FrequencyWords(List<string> words)
        {
            throw new NotImplementedException();
        }
    }
}
