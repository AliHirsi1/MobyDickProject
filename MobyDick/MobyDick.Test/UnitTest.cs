using MobyDick.Service.FileReader;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyDick.Test
{
    [TestFixture]
    public class UnitTest
    {
        TextFileReader reader = new TextFileReader();

        [Test]
        public void MobyDickReader_ReadersTextFile()
        {
            var result = reader.MobyDickReader();
            var title = "The Project Gutenberg EBook of Moby Dick;";
            Assert.AreEqual(title, result[0] + " " + result[1] + " " + result[2] + " " + result[3] + " " + result[4] + " " + result[5] + " " + result[6]);
        }


    }
}
