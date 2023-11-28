// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The minimum number of violations required within the selected lookback time window required to raise an alert. </summary>
    public partial class DynamicThresholdFailingPeriods
    {
        /// <summary> Initializes a new instance of <see cref="DynamicThresholdFailingPeriods"/>. </summary>
        /// <param name="numberOfEvaluationPeriods"> The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (windowSize) and the selected number of aggregated points. </param>
        /// <param name="minFailingPeriodsToAlert"> The number of violations to trigger an alert. Should be smaller or equal to numberOfEvaluationPeriods. </param>
        public DynamicThresholdFailingPeriods(float numberOfEvaluationPeriods, float minFailingPeriodsToAlert)
        {
            NumberOfEvaluationPeriods = numberOfEvaluationPeriods;
            MinFailingPeriodsToAlert = minFailingPeriodsToAlert;
        }

        /// <summary> The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (windowSize) and the selected number of aggregated points. </summary>
        public float NumberOfEvaluationPeriods { get; set; }
        /// <summary> The number of violations to trigger an alert. Should be smaller or equal to numberOfEvaluationPeriods. </summary>
        public float MinFailingPeriodsToAlert { get; set; }
    }
}
