// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for holding participant from the call. </summary>
    internal partial class HoldRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="HoldRequestInternal"/>. </summary>
        /// <param name="targetParticipant"> Participant to be held from the call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipant"/> is null. </exception>
        public HoldRequestInternal(CommunicationIdentifierModel targetParticipant)
        {
            Argument.AssertNotNull(targetParticipant, nameof(targetParticipant));

            TargetParticipant = targetParticipant;
        }

        /// <summary> Initializes a new instance of <see cref="HoldRequestInternal"/>. </summary>
        /// <param name="targetParticipant"> Participant to be held from the call. </param>
        /// <param name="playSourceInfo"> Prompt to play while in hold. </param>
        /// <param name="operationContext"> Used by customers when calling mid-call actions to correlate the request to the response event. </param>
        /// <param name="operationCallbackUri">
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </param>
        internal HoldRequestInternal(CommunicationIdentifierModel targetParticipant, PlaySourceInternal playSourceInfo, string operationContext, string operationCallbackUri)
        {
            TargetParticipant = targetParticipant;
            PlaySourceInfo = playSourceInfo;
            OperationContext = operationContext;
            OperationCallbackUri = operationCallbackUri;
        }

        /// <summary> Participant to be held from the call. </summary>
        public CommunicationIdentifierModel TargetParticipant { get; }
        /// <summary> Prompt to play while in hold. </summary>
        public PlaySourceInternal PlaySourceInfo { get; set; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
        /// <summary>
        /// Set a callback URI that overrides the default callback URI set by CreateCall/AnswerCall for this operation.
        /// This setup is per-action. If this is not set, the default callback URI set by CreateCall/AnswerCall will be used.
        /// </summary>
        public string OperationCallbackUri { get; set; }
    }
}
