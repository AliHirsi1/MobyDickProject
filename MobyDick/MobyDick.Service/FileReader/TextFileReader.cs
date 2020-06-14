using MobyDick.Service.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace MobyDick.Service.FileReader
{
    public class TextFileReader : IFileReader
    {
        public List<string> MobyDickReader()
        {
            // Retrieve file path from App.Config
            string fmobyFilePath = ConfigurationManager.AppSettings["mobyFilePath"];
            string mobyFilePath = @"C:\Users\Ali\Desktop\AlliesInc\SourceAllies\SourceAllies\TextFiles\mobydick.txt";
            List<String> mobdyDickWords = new List<string>(); // declare list string to add all text and return
            try
            {
                // check file exists before reading
                if (File.Exists(mobyFilePath))
                {
                    using (StreamReader sr = new StreamReader(mobyFilePath))
                    {
                        string line;
                        string[] words;
                        // read the whole file until the end
                        while ((line = sr.ReadLine()) != null)
                        {
                            // split lines into words by space
                            words = line.Split(" ");
                            foreach (var item in words)
                            {
                                //check empty string or null. 
                                // TODO- not sure if digits should be inclueded.
                                if (!String.IsNullOrEmpty(item))
                                {
                                    mobdyDickWords.Add(item);
                                }
                            }
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return mobdyDickWords;
        }

        public List<string> StopWordsReader()
        {
            throw new NotImplementedException();
        }
    }
}
