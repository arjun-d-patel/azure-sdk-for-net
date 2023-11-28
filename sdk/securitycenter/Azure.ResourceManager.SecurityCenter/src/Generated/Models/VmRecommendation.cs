// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents a machine that is part of a machine group. </summary>
    public partial class VmRecommendation
    {
        /// <summary> Initializes a new instance of <see cref="VmRecommendation"/>. </summary>
        public VmRecommendation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VmRecommendation"/>. </summary>
        /// <param name="configurationStatus"> The configuration status of the machines group or machine or rule. </param>
        /// <param name="recommendationAction"> The recommendation action of the machine or rule. </param>
        /// <param name="resourceId"> The full resource id of the machine. </param>
        /// <param name="enforcementSupport"> The machine supportability of Enforce feature. </param>
        internal VmRecommendation(SecurityCenterConfigurationStatus? configurationStatus, RecommendationAction? recommendationAction, ResourceIdentifier resourceId, SecurityCenterVmEnforcementSupportState? enforcementSupport)
        {
            ConfigurationStatus = configurationStatus;
            RecommendationAction = recommendationAction;
            ResourceId = resourceId;
            EnforcementSupport = enforcementSupport;
        }

        /// <summary> The configuration status of the machines group or machine or rule. </summary>
        public SecurityCenterConfigurationStatus? ConfigurationStatus { get; set; }
        /// <summary> The recommendation action of the machine or rule. </summary>
        public RecommendationAction? RecommendationAction { get; set; }
        /// <summary> The full resource id of the machine. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The machine supportability of Enforce feature. </summary>
        public SecurityCenterVmEnforcementSupportState? EnforcementSupport { get; set; }
    }
}
