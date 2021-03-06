// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The PrivateLinkResources service client. </summary>
    public partial class PrivateLinkResourcesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PrivateLinkResourcesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of PrivateLinkResourcesOperations for mocking. </summary>
        protected PrivateLinkResourcesOperations()
        {
        }
        /// <summary> Initializes a new instance of PrivateLinkResourcesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal PrivateLinkResourcesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01-preview")
        {
            RestClient = new PrivateLinkResourcesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the private link resources that need to be created for a workspace. </summary>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateLinkResourceListResult>> ListByWorkspaceAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.ListByWorkspace");
            scope.Start();
            try
            {
                return await RestClient.ListByWorkspaceAsync(resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the private link resources that need to be created for a workspace. </summary>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateLinkResourceListResult> ListByWorkspace(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateLinkResourcesOperations.ListByWorkspace");
            scope.Start();
            try
            {
                return RestClient.ListByWorkspace(resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
