// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes an automation rule action to modify an object's properties. </summary>
    public partial class AutomationRuleModifyPropertiesAction : SecurityInsightsAutomationRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="AutomationRuleModifyPropertiesAction"/>. </summary>
        /// <param name="order"></param>
        public AutomationRuleModifyPropertiesAction(int order) : base(order)
        {
            ActionType = ActionType.ModifyProperties;
        }

        /// <summary> Initializes a new instance of <see cref="AutomationRuleModifyPropertiesAction"/>. </summary>
        /// <param name="order"></param>
        /// <param name="actionType"> The type of the automation rule action. </param>
        /// <param name="actionConfiguration"></param>
        internal AutomationRuleModifyPropertiesAction(int order, ActionType actionType, SecurityInsightsIncidentActionConfiguration actionConfiguration) : base(order, actionType)
        {
            ActionConfiguration = actionConfiguration;
            ActionType = actionType;
        }

        /// <summary> Gets or sets the action configuration. </summary>
        public SecurityInsightsIncidentActionConfiguration ActionConfiguration { get; set; }
    }
}
