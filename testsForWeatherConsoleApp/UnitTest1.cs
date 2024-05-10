using WeatherConsoleApp;
using NUnit.Framework;
using System;

namespace TestProjectForWeatherConsoleApp
{
    public class Tests
    {
        Convertor convertor;

        [SetUp]
        public void Setup()
        {
            convertor = new Convertor();
        }

        [Test]
        public void Test1()
        {

            Assert.That(convertor.convertTofarenheits(1), Is.EqualTo(33));
            Assert.That(convertor.convertTofarenheits(286), Is.EqualTo(546));
            Assert.That(convertor.convertTofarenheits(0), Is.EqualTo(32));

            // Assert.Equals(33, 33);
            //Assert.Equals(546, 546);
            //Assert.Equals(3, convertor.convertTofarenheits(30));

            Assert.Pass();
        }
    }
}