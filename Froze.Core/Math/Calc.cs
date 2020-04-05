using Froze.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froze.Core.Math
{
    public class Calc
    {
        private readonly ILogger _logger;
        public Calc(ILogger logger)
        {
            _logger = logger;
        }

        public int Factorial(int ind)
        {
            _logger.Info("[Factorial] Start.");

            int result = 1;

            for (int i = 1; i <= ind; i++)
            {
                result *= i;
            }

            _logger.Info("[Factorial] Finish.");

            return result;
        }

        public async int FactorialAsync(int ind)
        {
            _logger.Info("[FactorialAsync] Start.");

            await Task.Run(() => Factorial(ind));  
            
            _logger.Info("[FactorialAsync] Finish.");

            return 0;
        }
    }
}
