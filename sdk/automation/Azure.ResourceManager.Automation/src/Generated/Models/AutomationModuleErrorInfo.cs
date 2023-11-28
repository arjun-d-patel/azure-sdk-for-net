// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the module error info type. </summary>
    public partial class AutomationModuleErrorInfo
    {
        /// <summary> Initializes a new instance of <see cref="AutomationModuleErrorInfo"/>. </summary>
        public AutomationModuleErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AutomationModuleErrorInfo"/>. </summary>
        /// <param name="code"> Gets or sets the error code. </param>
        /// <param name="message"> Gets or sets the error message. </param>
        internal AutomationModuleErrorInfo(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Gets or sets the error code. </summary>
        public string Code { get; set; }
        /// <summary> Gets or sets the error message. </summary>
        public string Message { get; set; }
    }
}
