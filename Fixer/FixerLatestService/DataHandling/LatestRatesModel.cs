using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.FixerLatestService.DataHandling
{
    public class LatestRatesRoot
    {
        public bool success { get; set; }
        public int timestamp { get; set; }
        public string bases { get; set; }
        public string date { get; set; }
        public Dictionary<string,float> rates { get; set; }
    }
}
