// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedInstanceAdministrator data model. </summary>
    public partial class ManagedInstanceAdministratorData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedInstanceAdministratorData. </summary>
        public ManagedInstanceAdministratorData()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceAdministratorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> Type of the managed instance administrator. </param>
        /// <param name="login"> Login name of the managed instance administrator. </param>
        /// <param name="sid"> SID (object ID) of the managed instance administrator. </param>
        /// <param name="tenantId"> Tenant ID of the managed instance administrator. </param>
        internal ManagedInstanceAdministratorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedInstanceAdministratorType? administratorType, string login, Guid? sid, Guid? tenantId) : base(id, name, resourceType, systemData)
        {
            AdministratorType = administratorType;
            Login = login;
            Sid = sid;
            TenantId = tenantId;
        }

        /// <summary> Type of the managed instance administrator. </summary>
        public ManagedInstanceAdministratorType? AdministratorType { get; set; }
        /// <summary> Login name of the managed instance administrator. </summary>
        public string Login { get; set; }
        /// <summary> SID (object ID) of the managed instance administrator. </summary>
        public Guid? Sid { get; set; }
        /// <summary> Tenant ID of the managed instance administrator. </summary>
        public Guid? TenantId { get; set; }
    }
}
