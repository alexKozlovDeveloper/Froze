using Froze.Core.Logging;
using Froze.NetFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.NetFeatures.Features
{
    class AsyncAwaitFeature : IFeature
    {
        private readonly ILogger _logger;

        public AsyncAwaitFeature(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            
        }
    }
}
