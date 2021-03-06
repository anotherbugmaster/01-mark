﻿using System;
using System.IO;
using html_generator;
using NUnit.Framework;

namespace GeneratorTestProject
{
    [TestFixture]
    public class GeneratorTest
    {
        [Test]
        public void Empty()
        {
            string input = File.ReadAllText(@"..\..\..\GeneratorTestProject\InputFiles\empty.txt");
            string output = Generator.GenerateHTML(input);
            string trueOutput = File.ReadAllText(@"..\..\..\GeneratorTestProject\OutputFiles\emptyConverted.txt");
            Assert.AreEqual(trueOutput, output);
        }
        [Test]
        public void LineInTheEnd()
        {
            string input = File.ReadAllText(@"..\..\..\GeneratorTestProject\InputFiles\lineInTheEnd.txt");
            string output = Generator.GenerateHTML(input);
            string trueOutput = File.ReadAllText(@"..\..\..\GeneratorTestProject\OutputFiles\lineInTheEndConverted.txt");
            Assert.AreEqual(trueOutput, output);
        }

    }
}
