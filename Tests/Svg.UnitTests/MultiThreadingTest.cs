using Microsoft.VisualStudio.TestTools.UnitTesting;
using Svg.Exceptions;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Svg.UnitTests
{

    [TestClass]
    public class MultiThreadingTest : SvgTestHelper
    {

        protected override string TestFile { get { return @"test.svg"; } }
        protected override int ExpectedSize { get { return 40000; } }

        private void LoadFile()
        {
            LoadSvg(GetXMLDocFromFile());
        }

        
        [TestMethod]
        public void TestSingleThread()
        {
            LoadFile();
        }


        [TestMethod]
        public void TestMultiThread()
        {
            Parallel.For(0, 10, (x) =>
            {
                LoadFile();
            });
            Trace.WriteLine("Done");
        }


        //stupid test
        //complited for 1000 iteration
        //[TestMethod]
        //[ExpectedException(typeof(SvgMemoryException))]
        //public void SVGGivesMemoryExceptionOnTooManyParallelTest()
        //{
        //    try
        //    {
        //        Parallel.For(0, 50, (x) =>
        //        {
        //            LoadFile();
        //        });
        //    }
        //    catch (AggregateException ex)
        //    {
        //        throw ex.InnerException;
        //    }
        //}
    }
}
