// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Authorization
{
    /// <summary> A Class representing a AccessReviewInstance along with the instance operations that can be performed on it. </summary>
    public partial class AccessReviewInstance : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AccessReviewInstancesRestOperations _accessReviewInstancesRestClient;
        private readonly AccessReviewInstanceRestOperations _accessReviewInstanceRestClient;
        private readonly AccessReviewInstanceDecisionsRestOperations _accessReviewInstanceDecisionsRestClient;
        private readonly AccessReviewInstanceData _data;

        /// <summary> Initializes a new instance of the <see cref="AccessReviewInstance"/> class for mocking. </summary>
        protected AccessReviewInstance()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AccessReviewInstance"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal AccessReviewInstance(ArmResource options, AccessReviewInstanceData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _accessReviewInstancesRestClient = new AccessReviewInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _accessReviewInstanceRestClient = new AccessReviewInstanceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _accessReviewInstanceDecisionsRestClient = new AccessReviewInstanceDecisionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="AccessReviewInstance"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AccessReviewInstance(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _accessReviewInstancesRestClient = new AccessReviewInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _accessReviewInstanceRestClient = new AccessReviewInstanceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _accessReviewInstanceDecisionsRestClient = new AccessReviewInstanceDecisionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="AccessReviewInstance"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AccessReviewInstance(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _accessReviewInstancesRestClient = new AccessReviewInstancesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _accessReviewInstanceRestClient = new AccessReviewInstanceRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _accessReviewInstanceDecisionsRestClient = new AccessReviewInstanceDecisionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/accessReviewScheduleDefinitions/instances";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AccessReviewInstanceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstances_GetById
        /// <summary> Get access review instances. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AccessReviewInstance>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.Get");
            scope.Start();
            try
            {
                var response = await _accessReviewInstancesRestClient.GetByIdAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AccessReviewInstance(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstances_GetById
        /// <summary> Get access review instances. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AccessReviewInstance> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.Get");
            scope.Start();
            try
            {
                var response = _accessReviewInstancesRestClient.GetById(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AccessReviewInstance(this, response.Value), response.GetRawResponse());
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/stop
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_Stop
        /// <summary> An action to stop an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StopAccessReviewInstanceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.StopAccessReviewInstance");
            scope.Start();
            try
            {
                var response = await _accessReviewInstanceRestClient.StopAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/stop
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_Stop
        /// <summary> An action to stop an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StopAccessReviewInstance(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.StopAccessReviewInstance");
            scope.Start();
            try
            {
                var response = _accessReviewInstanceRestClient.Stop(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/resetDecisions
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_ResetDecisions
        /// <summary> An action to reset all decisions for an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> ResetDecisionsAccessReviewInstanceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.ResetDecisionsAccessReviewInstance");
            scope.Start();
            try
            {
                var response = await _accessReviewInstanceRestClient.ResetDecisionsAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/resetDecisions
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_ResetDecisions
        /// <summary> An action to reset all decisions for an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ResetDecisionsAccessReviewInstance(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.ResetDecisionsAccessReviewInstance");
            scope.Start();
            try
            {
                var response = _accessReviewInstanceRestClient.ResetDecisions(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/applyDecisions
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_ApplyDecisions
        /// <summary> An action to apply all decisions for an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> ApplyDecisionsAccessReviewInstanceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.ApplyDecisionsAccessReviewInstance");
            scope.Start();
            try
            {
                var response = await _accessReviewInstanceRestClient.ApplyDecisionsAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/applyDecisions
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_ApplyDecisions
        /// <summary> An action to apply all decisions for an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ApplyDecisionsAccessReviewInstance(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.ApplyDecisionsAccessReviewInstance");
            scope.Start();
            try
            {
                var response = _accessReviewInstanceRestClient.ApplyDecisions(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/sendReminders
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_SendReminders
        /// <summary> An action to send reminders for an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> SendRemindersAccessReviewInstanceAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.SendRemindersAccessReviewInstance");
            scope.Start();
            try
            {
                var response = await _accessReviewInstanceRestClient.SendRemindersAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/sendReminders
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstance_SendReminders
        /// <summary> An action to send reminders for an access review instance. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response SendRemindersAccessReviewInstance(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.SendRemindersAccessReviewInstance");
            scope.Start();
            try
            {
                var response = _accessReviewInstanceRestClient.SendReminders(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/decisions
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstanceDecisions_List
        /// <summary> Get access review instance decisions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AccessReviewDecisionData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AccessReviewDecisionData> GetAccessReviewInstanceDecisionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AccessReviewDecisionData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.GetAccessReviewInstanceDecisions");
                scope.Start();
                try
                {
                    var response = await _accessReviewInstanceDecisionsRestClient.ListAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AccessReviewDecisionData>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.GetAccessReviewInstanceDecisions");
                scope.Start();
                try
                {
                    var response = await _accessReviewInstanceDecisionsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}/decisions
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}
        /// OperationId: AccessReviewInstanceDecisions_List
        /// <summary> Get access review instance decisions. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AccessReviewDecisionData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AccessReviewDecisionData> GetAccessReviewInstanceDecisions(CancellationToken cancellationToken = default)
        {
            Page<AccessReviewDecisionData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.GetAccessReviewInstanceDecisions");
                scope.Start();
                try
                {
                    var response = _accessReviewInstanceDecisionsRestClient.List(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AccessReviewDecisionData> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AccessReviewInstance.GetAccessReviewInstanceDecisions");
                scope.Start();
                try
                {
                    var response = _accessReviewInstanceDecisionsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
