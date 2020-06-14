using MobyDick.Service.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace MobyDick.Service.FileReader
{
    /*
    * Author: Ali H
    * 
    * This class is designed to only read two text files line by line
    * and break each line into words and return the text as list 
    * to be manipuated and return 100 most frequently occurring words excluding stoop-watch.
    * 
    */
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
            // Retrieve file path from App.Config
            //string stopWatchFilePath = ConfigurationManager.AppSettings["stopWordsFilePath"];
            string stopWatchFilePath = @"C:\Users\Ali\Desktop\AlliesInc\SourceAllies\SourceAllies\TextFiles\stop-words.txt";
            List<String> stopWatchText = new List<string>(); // declare list string to add all text and return
            try
            {
                if (File.Exists(stopWatchFilePath))
                {
                    using (StreamReader sr = new StreamReader(stopWatchFilePath))
                    {
                        string line;
                        string[] words;
                        // read the whole file
                        while ((line = sr.ReadLine()) != null)
                        {
                            // split lines into words by space
                            words = line.Split(" ");

                            // loop through words and put into the list
                            foreach (var item in words)
                            {
                                //check empty string or null. 
                                // TODO- not sure if digits should be inclueded.
                                if (!String.IsNullOrEmpty(item))
                                {
                                    stopWatchText.Add(item);
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
            return stopWatchText;
        }
    }
}
