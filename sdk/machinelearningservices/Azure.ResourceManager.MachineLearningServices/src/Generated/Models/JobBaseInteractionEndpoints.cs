// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary>
    /// Dictonary of endpoint URIs, keyed by enumerated job endpoints.
    /// 
    /// For local jobs, a job endpoint will have a value of FileStreamObject.
    /// </summary>
    public partial class JobBaseInteractionEndpoints
    {
        /// <summary> Initializes a new instance of JobBaseInteractionEndpoints. </summary>
        internal JobBaseInteractionEndpoints()
        {
        }

        /// <summary> Initializes a new instance of JobBaseInteractionEndpoints. </summary>
        /// <param name="tracking"> Any object. </param>
        /// <param name="studio"> Any object. </param>
        /// <param name="grafana"> Any object. </param>
        /// <param name="tensorboard"> Any object. </param>
        /// <param name="local"> Any object. </param>
        /// <param name="localRequest"> Any object. </param>
        internal JobBaseInteractionEndpoints(object tracking, object studio, object grafana, object tensorboard, object local, object localRequest)
        {
            Tracking = tracking;
            Studio = studio;
            Grafana = grafana;
            Tensorboard = tensorboard;
            Local = local;
            LocalRequest = localRequest;
        }

        /// <summary> Any object. </summary>
        public object Tracking { get; }
        /// <summary> Any object. </summary>
        public object Studio { get; }
        /// <summary> Any object. </summary>
        public object Grafana { get; }
        /// <summary> Any object. </summary>
        public object Tensorboard { get; }
        /// <summary> Any object. </summary>
        public object Local { get; }
        /// <summary> Any object. </summary>
        public object LocalRequest { get; }
    }
}
