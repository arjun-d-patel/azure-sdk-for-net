// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> ThreatIntelligence property bag. </summary>
    public partial class SecurityInsightsThreatIntelligence
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsThreatIntelligence"/>. </summary>
        internal SecurityInsightsThreatIntelligence()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsThreatIntelligence"/>. </summary>
        /// <param name="confidence"> Confidence (must be between 0 and 1). </param>
        /// <param name="providerName"> Name of the provider from whom this Threat Intelligence information was received. </param>
        /// <param name="reportLink"> Report link. </param>
        /// <param name="threatDescription"> Threat description (free text). </param>
        /// <param name="threatName"> Threat name (e.g. "Jedobot malware"). </param>
        /// <param name="threatType"> Threat type (e.g. "Botnet"). </param>
        internal SecurityInsightsThreatIntelligence(double? confidence, string providerName, string reportLink, string threatDescription, string threatName, string threatType)
        {
            Confidence = confidence;
            ProviderName = providerName;
            ReportLink = reportLink;
            ThreatDescription = threatDescription;
            ThreatName = threatName;
            ThreatType = threatType;
        }

        /// <summary> Confidence (must be between 0 and 1). </summary>
        public double? Confidence { get; }
        /// <summary> Name of the provider from whom this Threat Intelligence information was received. </summary>
        public string ProviderName { get; }
        /// <summary> Report link. </summary>
        public string ReportLink { get; }
        /// <summary> Threat description (free text). </summary>
        public string ThreatDescription { get; }
        /// <summary> Threat name (e.g. "Jedobot malware"). </summary>
        public string ThreatName { get; }
        /// <summary> Threat type (e.g. "Botnet"). </summary>
        public string ThreatType { get; }
    }
}
