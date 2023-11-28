// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a backup schedule. Describes how often should be the backup performed and what should be the retention policy. </summary>
    public partial class WebAppBackupSchedule
    {
        /// <summary> Initializes a new instance of <see cref="WebAppBackupSchedule"/>. </summary>
        /// <param name="frequencyInterval"> How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and FrequencyUnit should be set to Day). </param>
        /// <param name="frequencyUnit"> The unit of time for how often the backup should be executed (e.g. for weekly backup, this should be set to Day and FrequencyInterval should be set to 7). </param>
        /// <param name="shouldKeepAtLeastOneBackup"> True if the retention policy should always keep at least one backup in the storage account, regardless how old it is; false otherwise. </param>
        /// <param name="retentionPeriodInDays"> After how many days backups should be deleted. </param>
        public WebAppBackupSchedule(int frequencyInterval, BackupFrequencyUnit frequencyUnit, bool shouldKeepAtLeastOneBackup, int retentionPeriodInDays)
        {
            FrequencyInterval = frequencyInterval;
            FrequencyUnit = frequencyUnit;
            ShouldKeepAtLeastOneBackup = shouldKeepAtLeastOneBackup;
            RetentionPeriodInDays = retentionPeriodInDays;
        }

        /// <summary> Initializes a new instance of <see cref="WebAppBackupSchedule"/>. </summary>
        /// <param name="frequencyInterval"> How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and FrequencyUnit should be set to Day). </param>
        /// <param name="frequencyUnit"> The unit of time for how often the backup should be executed (e.g. for weekly backup, this should be set to Day and FrequencyInterval should be set to 7). </param>
        /// <param name="shouldKeepAtLeastOneBackup"> True if the retention policy should always keep at least one backup in the storage account, regardless how old it is; false otherwise. </param>
        /// <param name="retentionPeriodInDays"> After how many days backups should be deleted. </param>
        /// <param name="startOn"> When the schedule should start working. </param>
        /// <param name="lastExecutedOn"> Last time when this schedule was triggered. </param>
        internal WebAppBackupSchedule(int frequencyInterval, BackupFrequencyUnit frequencyUnit, bool shouldKeepAtLeastOneBackup, int retentionPeriodInDays, DateTimeOffset? startOn, DateTimeOffset? lastExecutedOn)
        {
            FrequencyInterval = frequencyInterval;
            FrequencyUnit = frequencyUnit;
            ShouldKeepAtLeastOneBackup = shouldKeepAtLeastOneBackup;
            RetentionPeriodInDays = retentionPeriodInDays;
            StartOn = startOn;
            LastExecutedOn = lastExecutedOn;
        }

        /// <summary> How often the backup should be executed (e.g. for weekly backup, this should be set to 7 and FrequencyUnit should be set to Day). </summary>
        public int FrequencyInterval { get; set; }
        /// <summary> The unit of time for how often the backup should be executed (e.g. for weekly backup, this should be set to Day and FrequencyInterval should be set to 7). </summary>
        public BackupFrequencyUnit FrequencyUnit { get; set; }
        /// <summary> True if the retention policy should always keep at least one backup in the storage account, regardless how old it is; false otherwise. </summary>
        public bool ShouldKeepAtLeastOneBackup { get; set; }
        /// <summary> After how many days backups should be deleted. </summary>
        public int RetentionPeriodInDays { get; set; }
        /// <summary> When the schedule should start working. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> Last time when this schedule was triggered. </summary>
        public DateTimeOffset? LastExecutedOn { get; }
    }
}
