using System;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using Fixer.FixerLatestService.HTTPManager;
using Fixer.FixerLatestService.DataHandling;

namespace Fixer.FixerLatestService
{
    public class FixerLatestService
    {
        //call manager
        public FixerLatestCallManager fixerLatestCallManager = new FixerLatestCallManager();
        public FixerLatestDTO fixerLatestDTO = new FixerLatestDTO();
        public JObject LatestRatesJson;

        public FixerLatestService() {
            fixerLatestDTO.DeserializeLatestRates(fixerLatestCallManager.GetLatestRates());
            LatestRatesJson = JObject.Parse(fixerLatestCallManager.GetLatestRates());
        }

        public int CountOfRates() {
            
            return fixerLatestDTO.Rates.Count;
        }
    }
}
