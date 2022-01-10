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
    /// <summary> A class representing collection of NetworkWatcher and their operations over its parent. </summary>
    public partial class NetworkWatcherCollection : ArmCollection, IEnumerable<NetworkWatcher>, IAsyncEnumerable<NetworkWatcher>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NetworkWatchersRestOperations _networkWatchersRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkWatcherCollection"/> class for mocking. </summary>
        protected NetworkWatcherCollection()
        {
        }

        /// <summary> Initializes a new instance of NetworkWatcherCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NetworkWatcherCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _networkWatchersRestClient = new NetworkWatchersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a network watcher in the specified resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NetworkWatcherCreateOrUpdateOperation CreateOrUpdate(string networkWatcherName, NetworkWatcherData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkWatchersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, parameters, cancellationToken);
                var operation = new NetworkWatcherCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Creates or updates a network watcher in the specified resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="parameters"> Parameters that define the network watcher resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NetworkWatcherCreateOrUpdateOperation> CreateOrUpdateAsync(string networkWatcherName, NetworkWatcherData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkWatchersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkWatcherCreateOrUpdateOperation(Parent, response);
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

        /// <summary> Gets the specified network watcher by resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<NetworkWatcher> Get(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = _networkWatchersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkWatcher(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified network watcher by resource group. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public async virtual Task<Response<NetworkWatcher>> GetAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkWatchersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NetworkWatcher(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<NetworkWatcher> GetIfExists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _networkWatchersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NetworkWatcher>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkWatcher(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public async virtual Task<Response<NetworkWatcher>> GetIfExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _networkWatchersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NetworkWatcher>(null, response.GetRawResponse())
                    : Response.FromValue(new NetworkWatcher(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(networkWatcherName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkWatcherName"> The name of the network watcher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkWatcherName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string networkWatcherName, CancellationToken cancellationToken = default)
        {
            if (networkWatcherName == null)
            {
                throw new ArgumentNullException(nameof(networkWatcherName));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(networkWatcherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all network watchers by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkWatcher" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkWatcher> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NetworkWatcher> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _networkWatchersRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcher(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Gets all network watchers by resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkWatcher" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkWatcher> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkWatcher>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _networkWatchersRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkWatcher(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="NetworkWatcher" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkWatcher.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NetworkWatcher" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkWatcherCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkWatcher.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkWatcher> IEnumerable<NetworkWatcher>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkWatcher> IAsyncEnumerable<NetworkWatcher>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, NetworkWatcher, NetworkWatcherData> Construct() { }
    }
}
