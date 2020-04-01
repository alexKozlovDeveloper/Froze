using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Core.Logging
{
    public class Logger : ILogger
    {
        private readonly ILog log = LogManager.GetLogger("LOGGER");
        
        public Logger()
        {
            InitLogger();
        }

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }

        private void Write(string msg)
        {
            log.Info(msg);
        }

        public void Error(string msg)
        {
            Write(msg);
        }

        public void Error(Exception e)
        {
            Write(e.Message);
        }

        public void Info(string msg)
        {
            Write(msg);
        }

        public void Warn(string msg)
        {
            Write(msg);
        }
    }
}
