// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan test failover input properties. </summary>
    public partial class RecoveryPlanTestFailoverProperties
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanTestFailoverProperties"/>. </summary>
        /// <param name="failoverDirection"> The failover direction. </param>
        /// <param name="networkType"> The network type to be used for test failover. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkType"/> is null. </exception>
        public RecoveryPlanTestFailoverProperties(PossibleOperationsDirection failoverDirection, string networkType)
        {
            Argument.AssertNotNull(networkType, nameof(networkType));

            FailoverDirection = failoverDirection;
            NetworkType = networkType;
            ProviderSpecificDetails = new ChangeTrackingList<RecoveryPlanProviderSpecificFailoverContent>();
        }

        /// <summary> The failover direction. </summary>
        public PossibleOperationsDirection FailoverDirection { get; }
        /// <summary> The network type to be used for test failover. </summary>
        public string NetworkType { get; }
        /// <summary> The Id of the network to be used for test failover. </summary>
        public ResourceIdentifier NetworkId { get; set; }
        /// <summary>
        /// The provider specific properties.
        /// Please note <see cref="RecoveryPlanProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>, <see cref="RecoveryPlanInMageFailoverContent"/>, <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>, <see cref="RecoveryPlanInMageRcmFailoverContent"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverContent"/>.
        /// </summary>
        public IList<RecoveryPlanProviderSpecificFailoverContent> ProviderSpecificDetails { get; }
    }
}
