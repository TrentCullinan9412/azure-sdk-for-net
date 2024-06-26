// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> ServiceNowV2 server linked service properties. </summary>
    internal partial class ServiceNowV2LinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="ServiceNowV2LinkedServiceTypeProperties"/>. </summary>
        /// <param name="endpoint"> The endpoint of the ServiceNowV2 server. (i.e. &lt;instance&gt;.service-now.com). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        internal ServiceNowV2LinkedServiceTypeProperties(object endpoint, ServiceNowV2AuthenticationType authenticationType)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            AuthenticationType = authenticationType;
        }

        /// <summary> Initializes a new instance of <see cref="ServiceNowV2LinkedServiceTypeProperties"/>. </summary>
        /// <param name="endpoint"> The endpoint of the ServiceNowV2 server. (i.e. &lt;instance&gt;.service-now.com). </param>
        /// <param name="authenticationType"> The authentication type to use. </param>
        /// <param name="username"> The user name used to connect to the ServiceNowV2 server for Basic and OAuth2 authentication. </param>
        /// <param name="password">
        /// The password corresponding to the user name for Basic and OAuth2 authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="clientId"> The client id for OAuth2 authentication. </param>
        /// <param name="clientSecret">
        /// The client secret for OAuth2 authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="grantType"> GrantType for OAuth2 authentication. Default value is password. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ServiceNowV2LinkedServiceTypeProperties(object endpoint, ServiceNowV2AuthenticationType authenticationType, object username, SecretBase password, object clientId, SecretBase clientSecret, object grantType, string encryptedCredential)
        {
            Endpoint = endpoint;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            ClientId = clientId;
            ClientSecret = clientSecret;
            GrantType = grantType;
            EncryptedCredential = encryptedCredential;
        }

        /// <summary> The endpoint of the ServiceNowV2 server. (i.e. &lt;instance&gt;.service-now.com). </summary>
        public object Endpoint { get; }
        /// <summary> The authentication type to use. </summary>
        public ServiceNowV2AuthenticationType AuthenticationType { get; }
        /// <summary> The user name used to connect to the ServiceNowV2 server for Basic and OAuth2 authentication. </summary>
        public object Username { get; }
        /// <summary>
        /// The password corresponding to the user name for Basic and OAuth2 authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; }
        /// <summary> The client id for OAuth2 authentication. </summary>
        public object ClientId { get; }
        /// <summary>
        /// The client secret for OAuth2 authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase ClientSecret { get; }
        /// <summary> GrantType for OAuth2 authentication. Default value is password. </summary>
        public object GrantType { get; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; }
    }
}
