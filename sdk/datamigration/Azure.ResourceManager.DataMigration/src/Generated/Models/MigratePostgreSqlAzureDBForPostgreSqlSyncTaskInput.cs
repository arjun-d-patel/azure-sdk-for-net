// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that migrates PostgreSQL databases to Azure Database for PostgreSQL for online migrations. </summary>
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput
    {
        /// <summary> Initializes a new instance of <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput"/>. </summary>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for PostgreSQL. </param>
        /// <param name="sourceConnectionInfo"> Connection information for source PostgreSQL. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="selectedDatabases"/>, <paramref name="targetConnectionInfo"/> or <paramref name="sourceConnectionInfo"/> is null. </exception>
        public MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput(IEnumerable<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput> selectedDatabases, PostgreSqlConnectionInfo targetConnectionInfo, PostgreSqlConnectionInfo sourceConnectionInfo)
        {
            Argument.AssertNotNull(selectedDatabases, nameof(selectedDatabases));
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));
            Argument.AssertNotNull(sourceConnectionInfo, nameof(sourceConnectionInfo));

            SelectedDatabases = selectedDatabases.ToList();
            TargetConnectionInfo = targetConnectionInfo;
            SourceConnectionInfo = sourceConnectionInfo;
        }

        /// <summary> Initializes a new instance of <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput"/>. </summary>
        /// <param name="selectedDatabases"> Databases to migrate. </param>
        /// <param name="targetConnectionInfo"> Connection information for target Azure Database for PostgreSQL. </param>
        /// <param name="sourceConnectionInfo"> Connection information for source PostgreSQL. </param>
        /// <param name="encryptedKeyForSecureFields"> encrypted key for secure fields. </param>
        /// <param name="startedOn"> Migration start time. </param>
        internal MigratePostgreSqlAzureDBForPostgreSqlSyncTaskInput(IList<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput> selectedDatabases, PostgreSqlConnectionInfo targetConnectionInfo, PostgreSqlConnectionInfo sourceConnectionInfo, string encryptedKeyForSecureFields, DateTimeOffset? startedOn)
        {
            SelectedDatabases = selectedDatabases;
            TargetConnectionInfo = targetConnectionInfo;
            SourceConnectionInfo = sourceConnectionInfo;
            EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
            StartedOn = startedOn;
        }

        /// <summary> Databases to migrate. </summary>
        public IList<MigratePostgreSqlAzureDBForPostgreSqlSyncDatabaseInput> SelectedDatabases { get; }
        /// <summary> Connection information for target Azure Database for PostgreSQL. </summary>
        public PostgreSqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Connection information for source PostgreSQL. </summary>
        public PostgreSqlConnectionInfo SourceConnectionInfo { get; set; }
        /// <summary> encrypted key for secure fields. </summary>
        public string EncryptedKeyForSecureFields { get; set; }
        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
    }
}
