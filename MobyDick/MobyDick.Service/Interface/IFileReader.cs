using System;
using System.Collections.Generic;
using System.Text;

namespace MobyDick.Service.Interface
{
    public interface IFileReader
    {
        List<string> MobyDickReader();
        List<string> StopWordsReader();
    }
}
