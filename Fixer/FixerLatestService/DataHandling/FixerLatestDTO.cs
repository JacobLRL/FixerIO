using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fixer.FixerLatestService.DataHandling
{
    public class FixerLatestDTO
    {
        public LatestRatesRoot LatestRates { get; set; }
        public Dictionary<string,float> Rates { get; set; }

        public void DeserializeLatestRates(string LatestRatesResponse) {
            LatestRates = JsonConvert.DeserializeObject<LatestRatesRoot>(LatestRatesResponse);
            Rates = LatestRates.rates;
        }
    }
}
