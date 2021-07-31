// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the operations that can be performed over a specific LabelingJobResource. </summary>
    public partial class LabelingJobResourceOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private LabelingJobsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="LabelingJobResourceOperations"/> class for mocking. </summary>
        protected LabelingJobResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LabelingJobResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal LabelingJobResourceOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new LabelingJobsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/labelingJobs";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets a labeling job by name/id. </summary>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LabelingJobResource>> GetAsync(bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, includeJobInstructions, includeLabelCategories, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new LabelingJobResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a labeling job by name/id. </summary>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LabelingJobResource> Get(bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, includeJobInstructions, includeLabelCategories, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LabelingJobResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Delete a labeling job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a labeling job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a labeling job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<LabelingJobsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new LabelingJobsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a labeling job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual LabelingJobsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new LabelingJobsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Pause a labeling job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PauseAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Pause");
            scope.Start();
            try
            {
                var response = await _restClient.PauseAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Pause a labeling job. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Pause(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Pause");
            scope.Start();
            try
            {
                var response = _restClient.Pause(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export labels from a labeling job (asynchronous). </summary>
        /// <param name="body"> The export summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async virtual Task<Response<ExportSummary>> ExportLabelsAsync(ExportSummary body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.ExportLabels");
            scope.Start();
            try
            {
                var operation = await StartExportLabelsAsync(body, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export labels from a labeling job (asynchronous). </summary>
        /// <param name="body"> The export summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual Response<ExportSummary> ExportLabels(ExportSummary body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.ExportLabels");
            scope.Start();
            try
            {
                var operation = StartExportLabels(body, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export labels from a labeling job (asynchronous). </summary>
        /// <param name="body"> The export summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public async virtual Task<LabelingJobsExportLabelsOperation> StartExportLabelsAsync(ExportSummary body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.StartExportLabels");
            scope.Start();
            try
            {
                var response = await _restClient.ExportLabelsAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken).ConfigureAwait(false);
                return new LabelingJobsExportLabelsOperation(_clientDiagnostics, Pipeline, _restClient.CreateExportLabelsRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Export labels from a labeling job (asynchronous). </summary>
        /// <param name="body"> The export summary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public virtual LabelingJobsExportLabelsOperation StartExportLabels(ExportSummary body, CancellationToken cancellationToken = default)
        {
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.StartExportLabels");
            scope.Start();
            try
            {
                var response = _restClient.ExportLabels(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body, cancellationToken);
                return new LabelingJobsExportLabelsOperation(_clientDiagnostics, Pipeline, _restClient.CreateExportLabelsRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, body).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resume a labeling job (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> ResumeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Resume");
            scope.Start();
            try
            {
                var operation = await StartResumeAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resume a labeling job (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Resume(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.Resume");
            scope.Start();
            try
            {
                var operation = StartResume(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resume a labeling job (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<LabelingJobsResumeOperation> StartResumeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.StartResume");
            scope.Start();
            try
            {
                var response = await _restClient.ResumeAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new LabelingJobsResumeOperation(_clientDiagnostics, Pipeline, _restClient.CreateResumeRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resume a labeling job (asynchronous). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual LabelingJobsResumeOperation StartResume(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LabelingJobResourceOperations.StartResume");
            scope.Start();
            try
            {
                var response = _restClient.Resume(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new LabelingJobsResumeOperation(_clientDiagnostics, Pipeline, _restClient.CreateResumeRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
