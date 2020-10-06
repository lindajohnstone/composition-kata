using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Composition
{
    public class HighPassSummingAggregator
    {
        IEnumerable<Measurement> _measurements;
        HighPassFilter _filter;
        SummingStrategy _aggregator;

        public HighPassSummingAggregator(IEnumerable<Measurement> measurements)
        {
            _measurements = measurements;
            _filter = new HighPassFilter();
            _aggregator = new SummingStrategy();
        }

        public Measurement Aggregate()
        {
            var measurement = _filter.Filter(_measurements);
            return _aggregator.Aggregate(measurement);
        }
    }
}