// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Url signing key parameters. </summary>
    internal partial class UrlSigningKeyParameters : SecretParameters
    {
        /// <summary> Initializes a new instance of UrlSigningKeyParameters. </summary>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="secretSource"> Resource reference to the KV secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyId"/> or <paramref name="secretSource"/> is null. </exception>
        public UrlSigningKeyParameters(string keyId, WritableSubResource secretSource)
        {
            if (keyId == null)
            {
                throw new ArgumentNullException(nameof(keyId));
            }
            if (secretSource == null)
            {
                throw new ArgumentNullException(nameof(secretSource));
            }

            KeyId = keyId;
            SecretSource = secretSource;
            SecretType = SecretType.UrlSigningKey;
        }

        /// <summary> Initializes a new instance of UrlSigningKeyParameters. </summary>
        /// <param name="secretType"> The type of the Secret to create. </param>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="secretSource"> Resource reference to the KV secret. </param>
        /// <param name="secretVersion"> Version of the secret to be used. </param>
        internal UrlSigningKeyParameters(SecretType secretType, string keyId, WritableSubResource secretSource, string secretVersion) : base(secretType)
        {
            KeyId = keyId;
            SecretSource = secretSource;
            SecretVersion = secretVersion;
            SecretType = secretType;
        }

        /// <summary> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </summary>
        public string KeyId { get; set; }
        /// <summary> Resource reference to the KV secret. </summary>
        internal WritableSubResource SecretSource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SecretSourceId
        {
            get => SecretSource is null ? default : SecretSource.Id;
            set
            {
                if (SecretSource is null)
                    SecretSource = new WritableSubResource();
                SecretSource.Id = value;
            }
        }

        /// <summary> Version of the secret to be used. </summary>
        public string SecretVersion { get; set; }
    }
}
