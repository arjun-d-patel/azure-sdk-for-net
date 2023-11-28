// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the GovernanceAssignment data model.
    /// Governance assignment over a given scope
    /// </summary>
    public partial class GovernanceAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="GovernanceAssignmentData"/>. </summary>
        public GovernanceAssignmentData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GovernanceAssignmentData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="owner"> The Owner for the governance assignment - e.g. user@contoso.com - see example. </param>
        /// <param name="remediationDueOn"> The remediation due-date - after this date Secure Score will be affected (in case of  active grace-period). </param>
        /// <param name="remediationEta"> The ETA (estimated time of arrival) for remediation (optional), see example. </param>
        /// <param name="isGracePeriod"> Defines whether there is a grace period on the governance assignment. </param>
        /// <param name="governanceEmailNotification"> The email notifications settings for the governance rule, states whether to disable notifications for mangers and owners. </param>
        /// <param name="additionalData"> The additional data for the governance assignment - e.g. links to ticket (optional), see example. </param>
        internal GovernanceAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string owner, DateTimeOffset? remediationDueOn, RemediationEta remediationEta, bool? isGracePeriod, GovernanceEmailNotification governanceEmailNotification, GovernanceAssignmentAdditionalInfo additionalData) : base(id, name, resourceType, systemData)
        {
            Owner = owner;
            RemediationDueOn = remediationDueOn;
            RemediationEta = remediationEta;
            IsGracePeriod = isGracePeriod;
            GovernanceEmailNotification = governanceEmailNotification;
            AdditionalData = additionalData;
        }

        /// <summary> The Owner for the governance assignment - e.g. user@contoso.com - see example. </summary>
        public string Owner { get; set; }
        /// <summary> The remediation due-date - after this date Secure Score will be affected (in case of  active grace-period). </summary>
        public DateTimeOffset? RemediationDueOn { get; set; }
        /// <summary> The ETA (estimated time of arrival) for remediation (optional), see example. </summary>
        public RemediationEta RemediationEta { get; set; }
        /// <summary> Defines whether there is a grace period on the governance assignment. </summary>
        public bool? IsGracePeriod { get; set; }
        /// <summary> The email notifications settings for the governance rule, states whether to disable notifications for mangers and owners. </summary>
        public GovernanceEmailNotification GovernanceEmailNotification { get; set; }
        /// <summary> The additional data for the governance assignment - e.g. links to ticket (optional), see example. </summary>
        public GovernanceAssignmentAdditionalInfo AdditionalData { get; set; }
    }
}
