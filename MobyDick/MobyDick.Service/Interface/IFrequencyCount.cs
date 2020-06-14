using System;
using System.Collections.Generic;
using System.Text;

namespace MobyDick.Service.Interface
{
    public interface IFrequencyCount
    {
        List<string> GetAllFrequencyWordsExcludingStopWatchWords();
        Dictionary<string, int> Top100FrequencyWords(List<string> words);

        bool IsInStopWords(string word);
    }
}
