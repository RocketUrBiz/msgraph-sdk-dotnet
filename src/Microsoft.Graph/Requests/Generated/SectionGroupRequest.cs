// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type SectionGroupRequest.
    /// </summary>
    public partial class SectionGroupRequest : BaseRequest, ISectionGroupRequest
    {
        /// <summary>
        /// Constructs a new SectionGroupRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public SectionGroupRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified SectionGroup using POST.
        /// </summary>
        /// <param name="sectionGroupToCreate">The SectionGroup to create.</param>
        /// <returns>The created SectionGroup.</returns>
        public System.Threading.Tasks.Task<SectionGroup> CreateAsync(SectionGroup sectionGroupToCreate)
        {
            return this.CreateAsync(sectionGroupToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified SectionGroup using POST.
        /// </summary>
        /// <param name="sectionGroupToCreate">The SectionGroup to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SectionGroup.</returns>
        public async System.Threading.Tasks.Task<SectionGroup> CreateAsync(SectionGroup sectionGroupToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<SectionGroup>(sectionGroupToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified SectionGroup.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified SectionGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<SectionGroup>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified SectionGroup.
        /// </summary>
        /// <returns>The SectionGroup.</returns>
        public System.Threading.Tasks.Task<SectionGroup> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified SectionGroup.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SectionGroup.</returns>
        public async System.Threading.Tasks.Task<SectionGroup> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<SectionGroup>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified SectionGroup using PATCH.
        /// </summary>
        /// <param name="sectionGroupToUpdate">The SectionGroup to update.</param>
        /// <returns>The updated SectionGroup.</returns>
        public System.Threading.Tasks.Task<SectionGroup> UpdateAsync(SectionGroup sectionGroupToUpdate)
        {
            return this.UpdateAsync(sectionGroupToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified SectionGroup using PATCH.
        /// </summary>
        /// <param name="sectionGroupToUpdate">The SectionGroup to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SectionGroup.</returns>
        public async System.Threading.Tasks.Task<SectionGroup> UpdateAsync(SectionGroup sectionGroupToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<SectionGroup>(sectionGroupToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISectionGroupRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ISectionGroupRequest Expand(Expression<Func<SectionGroup, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public ISectionGroupRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ISectionGroupRequest Select(Expression<Func<SectionGroup, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="sectionGroupToInitialize">The <see cref="SectionGroup"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(SectionGroup sectionGroupToInitialize)
        {

            if (sectionGroupToInitialize != null && sectionGroupToInitialize.AdditionalData != null)
            {

                if (sectionGroupToInitialize.Sections != null && sectionGroupToInitialize.Sections.CurrentPage != null)
                {
                    sectionGroupToInitialize.Sections.AdditionalData = sectionGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    sectionGroupToInitialize.AdditionalData.TryGetValue("sections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        sectionGroupToInitialize.Sections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (sectionGroupToInitialize.SectionGroups != null && sectionGroupToInitialize.SectionGroups.CurrentPage != null)
                {
                    sectionGroupToInitialize.SectionGroups.AdditionalData = sectionGroupToInitialize.AdditionalData;

                    object nextPageLink;
                    sectionGroupToInitialize.AdditionalData.TryGetValue("sectionGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        sectionGroupToInitialize.SectionGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
