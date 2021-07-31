// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing collection of BatchDeploymentTrackedResource and their operations over a BatchEndpointTrackedResource. </summary>
    public partial class BatchDeploymentTrackedResourceContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="BatchDeploymentTrackedResourceContainer"/> class for mocking. </summary>
        protected BatchDeploymentTrackedResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of BatchDeploymentTrackedResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BatchDeploymentTrackedResourceContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private BatchDeploymentsRestOperations _restClient => new BatchDeploymentsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => BatchEndpointTrackedResourceOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates/updates a batch inference deployment. </summary>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<BatchDeploymentTrackedResource> CreateOrUpdate(string deploymentName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(deploymentName, body, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates/updates a batch inference deployment. </summary>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<Response<BatchDeploymentTrackedResource>> CreateOrUpdateAsync(string deploymentName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(deploymentName, body, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates/updates a batch inference deployment. </summary>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="body"/> is null. </exception>
        public virtual BatchDeploymentsCreateOrUpdateOperation StartCreateOrUpdate(string deploymentName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, body, cancellationToken);
                return new BatchDeploymentsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates/updates a batch inference deployment. </summary>
        /// <param name="deploymentName"> The identifier for the Batch inference deployment. </param>
        /// <param name="body"> Batch inference deployment definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<BatchDeploymentsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string deploymentName, BatchDeploymentTrackedResourceData body, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, body, cancellationToken).ConfigureAwait(false);
                return new BatchDeploymentsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BatchDeploymentTrackedResource> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BatchDeploymentTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BatchDeploymentTrackedResource>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.Get");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BatchDeploymentTrackedResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BatchDeploymentTrackedResource> GetIfExists(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BatchDeploymentTrackedResource>(null, response.GetRawResponse())
                    : Response.FromValue(new BatchDeploymentTrackedResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BatchDeploymentTrackedResource>> GetIfExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetIfExists");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BatchDeploymentTrackedResource>(null, response.GetRawResponse())
                    : Response.FromValue(new BatchDeploymentTrackedResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = GetIfExists(deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The identifier for the Batch deployments. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = await GetIfExistsAsync(deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists Batch inference deployments in the workspace. </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BatchDeploymentTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<BatchDeploymentTrackedResource> GetAll(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            Page<BatchDeploymentTrackedResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BatchDeploymentTrackedResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists Batch inference deployments in the workspace. </summary>
        /// <param name="orderBy"> Ordering of list. </param>
        /// <param name="top"> Top of list. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BatchDeploymentTrackedResource" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<BatchDeploymentTrackedResource> GetAllAsync(string orderBy = null, int? top = null, string skip = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BatchDeploymentTrackedResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BatchDeploymentTrackedResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, orderBy, top, skip, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BatchDeploymentTrackedResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="BatchDeploymentTrackedResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BatchDeploymentTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BatchDeploymentTrackedResource" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BatchDeploymentTrackedResourceContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BatchDeploymentTrackedResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, BatchDeploymentTrackedResource, BatchDeploymentTrackedResourceData> Construct() { }
    }
}
