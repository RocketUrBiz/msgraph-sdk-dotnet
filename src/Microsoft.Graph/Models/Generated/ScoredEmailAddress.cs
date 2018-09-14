// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type ScoredEmailAddress.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ScoredEmailAddress
    {
    
        /// <summary>
        /// Gets or sets address.
        /// The email address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address", Required = Newtonsoft.Json.Required.Default)]
        public string Address { get; set; }
    
        /// <summary>
        /// Gets or sets relevanceScore.
        /// The relevance score of the email address. A relevance score is used as a sort key, in relation to the other returned results. A higher relevance score value corresponds to a more relevant result. Relevance is determined by the user's communication and collaboration patterns and business relationships.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "relevanceScore", Required = Newtonsoft.Json.Required.Default)]
        public double? RelevanceScore { get; set; }
    
        /// <summary>
        /// Gets or sets selectionLikelihood.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "selectionLikelihood", Required = Newtonsoft.Json.Required.Default)]
        public SelectionLikelihoodInfo? SelectionLikelihood { get; set; }
    
        /// <summary>
        /// Gets or sets ItemId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ItemId", Required = Newtonsoft.Json.Required.Default)]
        public string ItemId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
