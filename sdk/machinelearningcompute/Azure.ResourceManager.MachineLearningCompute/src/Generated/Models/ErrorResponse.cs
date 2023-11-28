// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Error response information. </summary>
    public partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorResponse(string code, string message)
        {
            Argument.AssertNotNull(code, nameof(code));
            Argument.AssertNotNull(message, nameof(message));

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<ErrorDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="ErrorResponse"/>. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message. </param>
        /// <param name="details"> An array of error detail objects. </param>
        internal ErrorResponse(string code, string message, IReadOnlyList<ErrorDetail> details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message. </summary>
        public string Message { get; }
        /// <summary> An array of error detail objects. </summary>
        public IReadOnlyList<ErrorDetail> Details { get; }
    }
}
