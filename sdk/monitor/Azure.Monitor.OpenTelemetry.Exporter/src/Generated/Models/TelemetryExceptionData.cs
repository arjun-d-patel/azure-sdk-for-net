// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> An instance of Exception represents a handled or unhandled exception that occurred during execution of the monitored application. </summary>
    internal partial class TelemetryExceptionData : MonitorDomain
    {
        /// <summary> Initializes a new instance of <see cref="TelemetryExceptionData"/>. </summary>
        /// <param name="version"> Schema version. </param>
        /// <param name="exceptions"> Exception chain - list of inner exceptions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exceptions"/> is null. </exception>
        public TelemetryExceptionData(int version, IEnumerable<TelemetryExceptionDetails> exceptions) : base(version)
        {
            Argument.AssertNotNull(exceptions, nameof(exceptions));

            Exceptions = exceptions.ToList();
            Properties = new ChangeTrackingDictionary<string, string>();
            Measurements = new ChangeTrackingDictionary<string, double>();
        }

        /// <summary> Exception chain - list of inner exceptions. </summary>
        public IList<TelemetryExceptionDetails> Exceptions { get; }
        /// <summary> Severity level. Mostly used to indicate exception severity level when it is reported by logging library. </summary>
        public SeverityLevel? SeverityLevel { get; set; }
        /// <summary> Identifier of where the exception was thrown in code. Used for exceptions grouping. Typically a combination of exception type and a function from the call stack. </summary>
        public string ProblemId { get; set; }
        /// <summary> Collection of custom properties. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Collection of custom measurements. </summary>
        public IDictionary<string, double> Measurements { get; }
    }
}
