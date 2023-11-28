// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Plan data of NewRelic Monitor resource. </summary>
    public partial class NewRelicPlanDetails
    {
        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDetails"/>. </summary>
        public NewRelicPlanDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicPlanDetails"/>. </summary>
        /// <param name="usageType"> Different usage type like PAYG/COMMITTED. this could be enum. </param>
        /// <param name="billingCycle"> Different billing cycles like MONTHLY/WEEKLY. this could be enum. </param>
        /// <param name="planDetails"> plan id as published by NewRelic. </param>
        /// <param name="effectiveOn"> date when plan was applied. </param>
        internal NewRelicPlanDetails(NewRelicObservabilityUsageType? usageType, NewRelicObservabilityBillingCycle? billingCycle, string planDetails, DateTimeOffset? effectiveOn)
        {
            UsageType = usageType;
            BillingCycle = billingCycle;
            PlanDetails = planDetails;
            EffectiveOn = effectiveOn;
        }

        /// <summary> Different usage type like PAYG/COMMITTED. this could be enum. </summary>
        public NewRelicObservabilityUsageType? UsageType { get; set; }
        /// <summary> Different billing cycles like MONTHLY/WEEKLY. this could be enum. </summary>
        public NewRelicObservabilityBillingCycle? BillingCycle { get; set; }
        /// <summary> plan id as published by NewRelic. </summary>
        public string PlanDetails { get; set; }
        /// <summary> date when plan was applied. </summary>
        public DateTimeOffset? EffectiveOn { get; set; }
    }
}
