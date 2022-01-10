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
    /// <summary> A class representing collection of VirtualNetwork and their operations over its parent. </summary>
    public partial class VirtualNetworkCollection : ArmCollection, IEnumerable<VirtualNetwork>, IAsyncEnumerable<VirtualNetwork>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworksRestOperations _virtualNetworksRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkCollection"/> class for mocking. </summary>
        protected VirtualNetworkCollection()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualNetworksRestClient = new VirtualNetworksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a virtual network in the specified resource group. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkCreateOrUpdateOperation CreateOrUpdate(string virtualNetworkName, VirtualNetworkData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworksRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters, cancellationToken);
                var operation = new VirtualNetworkCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters).Request, response);
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

        /// <summary> Creates or updates a virtual network in the specified resource group. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkCreateOrUpdateOperation> CreateOrUpdateAsync(string virtualNetworkName, VirtualNetworkData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworksRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _virtualNetworksRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, parameters).Request, response);
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

        /// <summary> Gets the specified virtual network by resource group. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<VirtualNetwork> Get(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetwork(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified virtual network by resource group. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetwork>> GetAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetwork(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<VirtualNetwork> GetIfExists(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworksRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualNetwork>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetwork(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetwork>> GetIfExistsAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualNetworksRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualNetwork>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualNetwork(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(virtualNetworkName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string virtualNetworkName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (virtualNetworkName == null)
            {
                throw new ArgumentNullException(nameof(virtualNetworkName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(virtualNetworkName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all virtual networks in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetwork" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetwork> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetwork> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworksRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetwork> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworksRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all virtual networks in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetwork" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetwork> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetwork>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworksRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetwork>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworksRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetwork(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetwork" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetwork.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetwork" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetwork.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetwork> IEnumerable<VirtualNetwork>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetwork> IAsyncEnumerable<VirtualNetwork>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualNetwork, VirtualNetworkData> Construct() { }
    }
}
