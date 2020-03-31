using Froze.NetFeatures.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.NetFeatures
{
    class FeatureRunner
    {
        public FeatureRunner()
        {

        }

        public void Run(IFeature feature)
        {
            feature.Run();
        }
    }
}
