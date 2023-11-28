// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Output for connect to MySQL type source. </summary>
    public partial class ConnectToSourceNonSqlTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToSourceNonSqlTaskOutput"/>. </summary>
        internal ConnectToSourceNonSqlTaskOutput()
        {
            Databases = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<ReportableException>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceNonSqlTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="sourceServerBrandVersion"> Server brand version. </param>
        /// <param name="serverProperties"> Server properties. </param>
        /// <param name="databases"> List of databases on the server. </param>
        /// <param name="validationErrors"> Validation errors associated with the task. </param>
        internal ConnectToSourceNonSqlTaskOutput(string id, string sourceServerBrandVersion, ServerProperties serverProperties, IReadOnlyList<string> databases, IReadOnlyList<ReportableException> validationErrors)
        {
            Id = id;
            SourceServerBrandVersion = sourceServerBrandVersion;
            ServerProperties = serverProperties;
            Databases = databases;
            ValidationErrors = validationErrors;
        }

        /// <summary> Result identifier. </summary>
        public string Id { get; }
        /// <summary> Server brand version. </summary>
        public string SourceServerBrandVersion { get; }
        /// <summary> Server properties. </summary>
        public ServerProperties ServerProperties { get; }
        /// <summary> List of databases on the server. </summary>
        public IReadOnlyList<string> Databases { get; }
        /// <summary> Validation errors associated with the task. </summary>
        public IReadOnlyList<ReportableException> ValidationErrors { get; }
    }
}
