// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Job output finished event data. </summary>
    public partial class MediaJobOutputFinishedEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary> Initializes a new instance of MediaJobOutputFinishedEventData. </summary>
        internal MediaJobOutputFinishedEventData()
        {
        }

        /// <summary> Initializes a new instance of MediaJobOutputFinishedEventData. </summary>
        /// <param name="previousState"> The previous state of the Job. </param>
        /// <param name="output"> Gets the output. </param>
        /// <param name="jobCorrelationData"> Gets the Job correlation data. </param>
        internal MediaJobOutputFinishedEventData(MediaJobState? previousState, MediaJobOutput output, IReadOnlyDictionary<string, string> jobCorrelationData) : base(previousState, output, jobCorrelationData)
        {
        }
    }
}
