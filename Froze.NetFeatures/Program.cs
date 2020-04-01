using Froze.Core.Logging;
using Froze.NetFeatures.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.NetFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            var runner = new FeatureRunner();

            var feature = new AsyncAwaitFeature(logger);

            runner.Run(feature);
        }
    }
}
