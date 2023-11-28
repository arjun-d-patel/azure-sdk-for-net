// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The RootCauseList. </summary>
    internal partial class RootCauseList
    {
        /// <summary> Initializes a new instance of <see cref="RootCauseList"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RootCauseList(IEnumerable<IncidentRootCause> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RootCauseList"/>. </summary>
        /// <param name="value"></param>
        internal RootCauseList(IReadOnlyList<IncidentRootCause> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<IncidentRootCause> Value { get; }
    }
}
