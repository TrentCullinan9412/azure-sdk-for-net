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
    /// <summary> A class representing the Image data model. </summary>
    public partial class ImageData : TrackedResource
    {
        /// <summary> Initializes a new instance of ImageData. </summary>
        /// <param name="location"> The location. </param>
        public ImageData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the Image. </param>
        /// <param name="sourceVirtualMachine"> The source virtual machine from which Image is created. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="hyperVGeneration"> Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed resource. </param>
        internal ImageData(ResourceIdentifier id, string name, ResourceType type, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, WritableSubResource sourceVirtualMachine, ImageStorageProfile storageProfile, string provisioningState, HyperVGenerationTypes? hyperVGeneration) : base(id, name, type, tags, location)
        {
            ExtendedLocation = extendedLocation;
            SourceVirtualMachine = sourceVirtualMachine;
            StorageProfile = storageProfile;
            ProvisioningState = provisioningState;
            HyperVGeneration = hyperVGeneration;
        }

        /// <summary> The extended location of the Image. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The source virtual machine from which Image is created. </summary>
        public WritableSubResource SourceVirtualMachine { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public ImageStorageProfile StorageProfile { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed resource. </summary>
        public HyperVGenerationTypes? HyperVGeneration { get; set; }
    }
}
