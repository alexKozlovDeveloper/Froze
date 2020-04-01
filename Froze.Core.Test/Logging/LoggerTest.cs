using System;
using System.IO;
using Froze.Core.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Froze.Core.Test
{
    [TestClass]
    public class LoggerTest
    {
        [TestMethod]
        public void Test_Create()
        {
            try
            {
                var logger = new Logger();

                logger.Info("Test Info");
                logger.Warn("Test Warn");
                logger.Error("Test Error [string]");
                logger.Error(new NotSupportedException("Test Error [exception]"));
            }
            catch (Exception)
            {
                Assert.Fail();
            }

            
        }
    }
}
