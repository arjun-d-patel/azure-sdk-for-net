// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
    public partial class NewRelicObservabilityLogRules
    {
        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityLogRules"/>. </summary>
        public NewRelicObservabilityLogRules()
        {
            FilteringTags = new ChangeTrackingList<NewRelicObservabilityFilteringTag>();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityLogRules"/>. </summary>
        /// <param name="sendAadLogs"> Flag specifying if AAD logs should be sent for the Monitor resource. </param>
        /// <param name="sendSubscriptionLogs"> Flag specifying if subscription logs should be sent for the Monitor resource. </param>
        /// <param name="sendActivityLogs"> Flag specifying if activity logs from Azure resources should be sent for the Monitor resource. </param>
        /// <param name="filteringTags">
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </param>
        internal NewRelicObservabilityLogRules(NewRelicObservabilitySendAadLogsStatus? sendAadLogs, NewRelicObservabilitySendSubscriptionLogsStatus? sendSubscriptionLogs, NewRelicObservabilitySendActivityLogsStatus? sendActivityLogs, IList<NewRelicObservabilityFilteringTag> filteringTags)
        {
            SendAadLogs = sendAadLogs;
            SendSubscriptionLogs = sendSubscriptionLogs;
            SendActivityLogs = sendActivityLogs;
            FilteringTags = filteringTags;
        }

        /// <summary> Flag specifying if AAD logs should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendAadLogsStatus? SendAadLogs { get; set; }
        /// <summary> Flag specifying if subscription logs should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendSubscriptionLogsStatus? SendSubscriptionLogs { get; set; }
        /// <summary> Flag specifying if activity logs from Azure resources should be sent for the Monitor resource. </summary>
        public NewRelicObservabilitySendActivityLogsStatus? SendActivityLogs { get; set; }
        /// <summary>
        /// List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.
        /// If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
        /// </summary>
        public IList<NewRelicObservabilityFilteringTag> FilteringTags { get; }
    }
}
