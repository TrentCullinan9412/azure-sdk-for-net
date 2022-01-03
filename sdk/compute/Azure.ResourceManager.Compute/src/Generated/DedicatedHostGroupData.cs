// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing the DedicatedHostGroup data model. </summary>
    public partial class DedicatedHostGroupData : TrackedResource
    {
        /// <summary> Initializes a new instance of DedicatedHostGroupData. </summary>
        /// <param name="location"> The location. </param>
        public DedicatedHostGroupData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
            Hosts = new ChangeTrackingList<Resources.Models.SubResource>();
        }

        /// <summary> Initializes a new instance of DedicatedHostGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone. </param>
        /// <param name="platformFaultDomainCount"> Number of fault domains that the host group can span. </param>
        /// <param name="hosts"> A list of references to all dedicated hosts in the dedicated host group. </param>
        /// <param name="instanceView"> The dedicated host group instance view, which has the list of instance view of the dedicated hosts under the dedicated host group. </param>
        /// <param name="supportAutomaticPlacement"> Specifies whether virtual machines or virtual machine scale sets can be placed automatically on the dedicated host group. Automatic placement means resources are allocated on dedicated hosts, that are chosen by Azure, under the dedicated host group. The value is defaulted to &apos;false&apos; when not provided. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01. </param>
        internal DedicatedHostGroupData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, int? platformFaultDomainCount, IReadOnlyList<Resources.Models.SubResource> hosts, DedicatedHostGroupInstanceView instanceView, bool? supportAutomaticPlacement) : base(id, name, type, tags, location)
        {
            Zones = zones;
            PlatformFaultDomainCount = platformFaultDomainCount;
            Hosts = hosts;
            InstanceView = instanceView;
            SupportAutomaticPlacement = supportAutomaticPlacement;
        }

        /// <summary> Availability Zone to use for this host group. Only single zone is supported. The zone can be assigned only during creation. If not provided, the group supports all zones in the region. If provided, enforces each host in the group to be in the same zone. </summary>
        public IList<string> Zones { get; }
        /// <summary> Number of fault domains that the host group can span. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> A list of references to all dedicated hosts in the dedicated host group. </summary>
        public IReadOnlyList<Resources.Models.SubResource> Hosts { get; }
        /// <summary> The dedicated host group instance view, which has the list of instance view of the dedicated hosts under the dedicated host group. </summary>
        public DedicatedHostGroupInstanceView InstanceView { get; }
        /// <summary> Specifies whether virtual machines or virtual machine scale sets can be placed automatically on the dedicated host group. Automatic placement means resources are allocated on dedicated hosts, that are chosen by Azure, under the dedicated host group. The value is defaulted to &apos;false&apos; when not provided. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01. </summary>
        public bool? SupportAutomaticPlacement { get; set; }
    }
}
