using MobyDick.Service.FileReader;
using MobyDick.Service;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyDick.Test
{
    [TestFixture]
    public class UnitTest
    {
        TextFileReader _reader = new TextFileReader();
        Top100MostccurringWords _topCount = new Top100MostccurringWords();

        [Test]
        public void MobyDickReader_ReadersTextFile()
        {
            var result = _reader.MobyDickReader();
            var title = "The Project Gutenberg EBook of Moby Dick;";
            Assert.AreEqual(title, result[0] + " " + result[1] + " " + result[2] + " " + result[3] + " " + result[4] + " " + result[5] + " " + result[6]);
        }

        [Test]
        public void Top100MostccurringWords_IsInStopWords()
        {
            var word = "about";
            var result = _topCount.IsInStopWords(word);
            Assert.AreEqual(result, true);
        }


    }
}
