using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Core.Logging
{
    public interface ILogger
    {
        void Info(string msg);
        void Warn(string msg);
        void Error(string msg);
        void Error(Exception e);
    }
}
