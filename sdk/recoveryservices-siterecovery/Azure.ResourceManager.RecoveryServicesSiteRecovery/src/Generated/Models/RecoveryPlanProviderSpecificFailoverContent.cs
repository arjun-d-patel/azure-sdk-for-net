// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Recovery plan provider specific failover input.
    /// Please note <see cref="RecoveryPlanProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="RecoveryPlanA2AFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>, <see cref="RecoveryPlanInMageFailoverContent"/>, <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>, <see cref="RecoveryPlanInMageRcmFailoverContent"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverContent"/>.
    /// </summary>
    public abstract partial class RecoveryPlanProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanProviderSpecificFailoverContent"/>. </summary>
        protected RecoveryPlanProviderSpecificFailoverContent()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
