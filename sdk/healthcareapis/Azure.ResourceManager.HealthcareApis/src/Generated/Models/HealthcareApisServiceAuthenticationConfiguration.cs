// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Authentication configuration information. </summary>
    public partial class HealthcareApisServiceAuthenticationConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAuthenticationConfiguration"/>. </summary>
        public HealthcareApisServiceAuthenticationConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareApisServiceAuthenticationConfiguration"/>. </summary>
        /// <param name="authority"> The authority url for the service. </param>
        /// <param name="audience"> The audience url for the service. </param>
        /// <param name="isSmartProxyEnabled"> If the SMART on FHIR proxy is enabled. </param>
        internal HealthcareApisServiceAuthenticationConfiguration(string authority, string audience, bool? isSmartProxyEnabled)
        {
            Authority = authority;
            Audience = audience;
            IsSmartProxyEnabled = isSmartProxyEnabled;
        }

        /// <summary> The authority url for the service. </summary>
        public string Authority { get; set; }
        /// <summary> The audience url for the service. </summary>
        public string Audience { get; set; }
        /// <summary> If the SMART on FHIR proxy is enabled. </summary>
        public bool? IsSmartProxyEnabled { get; set; }
    }
}
