// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper-V Replica Blue specific protection profile details. </summary>
    public partial class HyperVReplicaBluePolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of <see cref="HyperVReplicaBluePolicyDetails"/>. </summary>
        internal HyperVReplicaBluePolicyDetails()
        {
            InstanceType = "HyperVReplica2012R2";
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaBluePolicyDetails"/>. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        /// <param name="replicationFrequencyInSeconds"> A value indicating the replication interval. </param>
        /// <param name="recoveryPoints"> A value indicating the number of recovery points. </param>
        /// <param name="applicationConsistentSnapshotFrequencyInHours"> A value indicating the application consistent frequency. </param>
        /// <param name="compression"> A value indicating whether compression has to be enabled. </param>
        /// <param name="initialReplicationMethod"> A value indicating whether IR is online. </param>
        /// <param name="onlineReplicationStartTime"> A value indicating the online IR start time. </param>
        /// <param name="offlineReplicationImportPath"> A value indicating the offline IR import path. </param>
        /// <param name="offlineReplicationExportPath"> A value indicating the offline IR export path. </param>
        /// <param name="replicationPort"> A value indicating the recovery HTTPS port. </param>
        /// <param name="allowedAuthenticationType"> A value indicating the authentication type. </param>
        /// <param name="replicaDeletionOption"> A value indicating whether the VM has to be auto deleted. Supported Values: String.Empty, None, OnRecoveryCloud. </param>
        internal HyperVReplicaBluePolicyDetails(string instanceType, int? replicationFrequencyInSeconds, int? recoveryPoints, int? applicationConsistentSnapshotFrequencyInHours, string compression, string initialReplicationMethod, string onlineReplicationStartTime, string offlineReplicationImportPath, string offlineReplicationExportPath, int? replicationPort, int? allowedAuthenticationType, string replicaDeletionOption) : base(instanceType)
        {
            ReplicationFrequencyInSeconds = replicationFrequencyInSeconds;
            RecoveryPoints = recoveryPoints;
            ApplicationConsistentSnapshotFrequencyInHours = applicationConsistentSnapshotFrequencyInHours;
            Compression = compression;
            InitialReplicationMethod = initialReplicationMethod;
            OnlineReplicationStartTime = onlineReplicationStartTime;
            OfflineReplicationImportPath = offlineReplicationImportPath;
            OfflineReplicationExportPath = offlineReplicationExportPath;
            ReplicationPort = replicationPort;
            AllowedAuthenticationType = allowedAuthenticationType;
            ReplicaDeletionOption = replicaDeletionOption;
            InstanceType = instanceType ?? "HyperVReplica2012R2";
        }

        /// <summary> A value indicating the replication interval. </summary>
        public int? ReplicationFrequencyInSeconds { get; }
        /// <summary> A value indicating the number of recovery points. </summary>
        public int? RecoveryPoints { get; }
        /// <summary> A value indicating the application consistent frequency. </summary>
        public int? ApplicationConsistentSnapshotFrequencyInHours { get; }
        /// <summary> A value indicating whether compression has to be enabled. </summary>
        public string Compression { get; }
        /// <summary> A value indicating whether IR is online. </summary>
        public string InitialReplicationMethod { get; }
        /// <summary> A value indicating the online IR start time. </summary>
        public string OnlineReplicationStartTime { get; }
        /// <summary> A value indicating the offline IR import path. </summary>
        public string OfflineReplicationImportPath { get; }
        /// <summary> A value indicating the offline IR export path. </summary>
        public string OfflineReplicationExportPath { get; }
        /// <summary> A value indicating the recovery HTTPS port. </summary>
        public int? ReplicationPort { get; }
        /// <summary> A value indicating the authentication type. </summary>
        public int? AllowedAuthenticationType { get; }
        /// <summary> A value indicating whether the VM has to be auto deleted. Supported Values: String.Empty, None, OnRecoveryCloud. </summary>
        public string ReplicaDeletionOption { get; }
    }
}
