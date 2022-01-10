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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of WebJob and their operations over its parent. </summary>
    public partial class SiteWebJobCollection : ArmCollection, IEnumerable<SiteWebJob>, IAsyncEnumerable<SiteWebJob>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteWebJobCollection"/> class for mocking. </summary>
        protected SiteWebJobCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteWebJobCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteWebJobCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => WebSite.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/webjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetWebJob
        /// <summary> Description for Get webjob information for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteWebJob> Get(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteWebJob(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/webjobs/{webJobName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_GetWebJob
        /// <summary> Description for Get webjob information for an app, or a deployment slot. </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteWebJob>> GetAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteWebJob(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<SiteWebJob> GetIfExists(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteWebJob>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteWebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<SiteWebJob>> GetIfExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteWebJob>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteWebJob(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public virtual Response<bool> Exists(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(webJobName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="webJobName"> Name of the web job. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="webJobName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string webJobName, CancellationToken cancellationToken = default)
        {
            if (webJobName == null)
            {
                throw new ArgumentNullException(nameof(webJobName));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(webJobName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/webjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListWebJobs
        /// <summary> Description for List webjobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteWebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteWebJob> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteWebJob> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListWebJobs(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteWebJob> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListWebJobsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/webjobs
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}
        /// OperationId: WebApps_ListWebJobs
        /// <summary> Description for List webjobs for an app, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteWebJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteWebJob> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteWebJob>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListWebJobsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteWebJob>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteWebJobCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListWebJobsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteWebJob(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteWebJob> IEnumerable<SiteWebJob>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteWebJob> IAsyncEnumerable<SiteWebJob>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteWebJob, WebJobData> Construct() { }
    }
}
