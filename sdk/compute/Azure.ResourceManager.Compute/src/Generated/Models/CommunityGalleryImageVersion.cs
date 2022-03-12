// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery image version that you want to create or update. </summary>
    public partial class CommunityGalleryImageVersion : PirCommunityGalleryResource
    {
        /// <summary> Initializes a new instance of CommunityGalleryImageVersion. </summary>
        internal CommunityGalleryImageVersion()
        {
        }

        /// <summary> Initializes a new instance of CommunityGalleryImageVersion. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="pirCommunityGalleryResourceType"> Resource type. </param>
        /// <param name="uniqueId"> The unique id of this community gallery. </param>
        /// <param name="publishedDate"> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="endOfLifeDate"> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        internal CommunityGalleryImageVersion(string name, string location, string pirCommunityGalleryResourceType, string uniqueId, DateTimeOffset? publishedDate, DateTimeOffset? endOfLifeDate) : base(name, location, pirCommunityGalleryResourceType, uniqueId)
        {
            PublishedDate = publishedDate;
            EndOfLifeDate = endOfLifeDate;
        }

        /// <summary> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? PublishedDate { get; }
        /// <summary> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; }
    }
}
