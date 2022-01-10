// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ServiceEndpointPolicy and their operations over its parent. </summary>
    public partial class ServiceEndpointPolicyCollection : ArmCollection, IEnumerable<ServiceEndpointPolicy>, IAsyncEnumerable<ServiceEndpointPolicy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ServiceEndpointPoliciesRestOperations _serviceEndpointPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceEndpointPolicyCollection"/> class for mocking. </summary>
        protected ServiceEndpointPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of ServiceEndpointPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServiceEndpointPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _serviceEndpointPoliciesRestClient = new ServiceEndpointPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a service Endpoint Policies. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ServiceEndpointPolicyCreateOrUpdateOperation CreateOrUpdate(string serviceEndpointPolicyName, ServiceEndpointPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceEndpointPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, parameters, cancellationToken);
                var operation = new ServiceEndpointPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serviceEndpointPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a service Endpoint Policies. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update service endpoint policy operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ServiceEndpointPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(string serviceEndpointPolicyName, ServiceEndpointPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceEndpointPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _serviceEndpointPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified service Endpoint Policies in a specified resource group. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual Response<ServiceEndpointPolicy> Get(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceEndpointPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceEndpointPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified service Endpoint Policies in a specified resource group. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public async virtual Task<Response<ServiceEndpointPolicy>> GetAsync(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServiceEndpointPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual Response<ServiceEndpointPolicy> GetIfExists(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _serviceEndpointPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ServiceEndpointPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ServiceEndpointPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public async virtual Task<Response<ServiceEndpointPolicy>> GetIfExistsAsync(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _serviceEndpointPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, serviceEndpointPolicyName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ServiceEndpointPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ServiceEndpointPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(serviceEndpointPolicyName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="serviceEndpointPolicyName"> The name of the service endpoint policy. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceEndpointPolicyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string serviceEndpointPolicyName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (serviceEndpointPolicyName == null)
            {
                throw new ArgumentNullException(nameof(serviceEndpointPolicyName));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(serviceEndpointPolicyName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all service endpoint Policies in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceEndpointPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceEndpointPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceEndpointPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceEndpointPoliciesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceEndpointPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceEndpointPoliciesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all service endpoint Policies in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceEndpointPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceEndpointPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceEndpointPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceEndpointPoliciesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceEndpointPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceEndpointPoliciesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceEndpointPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="ServiceEndpointPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ServiceEndpointPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="ServiceEndpointPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceEndpointPolicyCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ServiceEndpointPolicy.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceEndpointPolicy> IEnumerable<ServiceEndpointPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceEndpointPolicy> IAsyncEnumerable<ServiceEndpointPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServiceEndpointPolicy, ServiceEndpointPolicyData> Construct() { }
    }
}
