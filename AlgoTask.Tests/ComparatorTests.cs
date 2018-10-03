using NUnit.Framework;
using AlgoTask;
using System;

namespace Tests
{
    [TestFixture]
    public class ComparatorTests
    {
        private double[] testData;

        [SetUp]
        public void Setup()
        {
            // create four random values
            /*          
                    testData = new double[4];
                    Random rand = new Random();
                    for (int i = 0; i < testData.Length; i++)
                    {
                        testData[i] = rand.NextDouble();
                    } 
            */

            testData = new double[] { 0.0, Math.PI, -32.9999, 7.67 };


        }

        [Test]
        public void Test1()
        {

            /* 
                Console.WriteLine("TEST DATA: ");
                for (int i = 0; i < testData.Length; i++)
                {
                    Console.Write(testData[i] + " ");
                } 
            */

            // compare with result of Math methods
            Assert.True(Math.Max(testData[0], testData[1]).CompareTo(RealNumberComparator.Max2(testData[0], testData[1])) == 0);
            Assert.True(Math.Min(testData[0], testData[1]).CompareTo(RealNumberComparator.Min2(testData[0], testData[1])) == 0);
            Assert.True(Math.Max(testData[0], testData[2]).CompareTo(RealNumberComparator.Max2(testData[0], testData[2])) == 0);
            Assert.True(Math.Min(testData[0], testData[2]).CompareTo(RealNumberComparator.Min2(testData[0], testData[2])) == 0);
            Assert.True(Math.Max(testData[0], testData[3]).CompareTo(RealNumberComparator.Max2(testData[0], testData[3])) == 0);
            Assert.True(Math.Min(testData[0], testData[3]).CompareTo(RealNumberComparator.Min2(testData[0], testData[3])) == 0);

        }
    }
}