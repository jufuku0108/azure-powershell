// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Extensions;

    /// <summary>The Virtual Network resource definition.</summary>
    public partial class VirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetwork,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.TrackedResource();

        /// <summary>The error code from the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Code = value ?? null; }

        /// <summary>List of DNS server IP Addresses associated with the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> DnsServer { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).DnsServer; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).DnsServer = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ExtendedLocation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocation _extendedLocation;

        /// <summary>Extended location pointing to the underlying infrastructure</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocation ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.VirtualNetworkExtendedLocation()); set => this._extendedLocation = value; }

        /// <summary>ARM Id of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string ExtendedLocationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocationInternal)ExtendedLocation).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocationInternal)ExtendedLocation).Name = value ?? null; }

        /// <summary>The extended location type. Allowed value: 'CustomLocation'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string ExtendedLocationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocationInternal)ExtendedLocation).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocationInternal)ExtendedLocation).Type = value ?? null; }

        /// <summary>IP Address of the Gateway associated with the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string Gateway { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Gateway; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Gateway = value ?? null; }

        /// <summary>Group in MOC(Microsoft On-premises Cloud)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string HciMocGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).HciMocGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).HciMocGroup = value ?? null; }

        /// <summary>Location in MOC(Microsoft On-premises Cloud)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string HciMocLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).HciMocLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).HciMocLocation = value ?? null; }

        /// <summary>Virtual Network name in MOC(Microsoft On-premises Cloud)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string HciMocVnetName { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).HciMocVnetName; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).HciMocVnetName = value ?? null; }

        /// <summary>IP Address Prefix of the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string IPAddressPrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).IPAddressPrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).IPAddressPrefix = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>The error message from the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Message = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Internal Acessors for ExtendedLocation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocation Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.ExtendedLocation { get => (this._extendedLocation = this._extendedLocation ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.VirtualNetworkExtendedLocation()); set { {_extendedLocation = value;} } }

        /// <summary>Internal Acessors for InfraVnetProfile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInfraVnetProfile Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.InfraVnetProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).InfraVnetProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).InfraVnetProfile = value; }

        /// <summary>Internal Acessors for InfraVnetProfileHci</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInfraVnetProfileHci Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.InfraVnetProfileHci { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).InfraVnetProfileHci; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).InfraVnetProfileHci = value; }

        /// <summary>Internal Acessors for OperationStatusError</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesStatusOperationStatusError Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.OperationStatusError { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).OperationStatusError; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).OperationStatusError = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkProperties Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.VirtualNetworkProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesStatus Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for StatusOperationStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesStatusOperationStatus Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkInternal.StatusOperationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).StatusOperationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).StatusOperationStatus = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>The status of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string OperationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).OperationStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).OperationStatus = value ?? null; }

        /// <summary>The identifier of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string OperationStatusOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).OperationStatusOperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).OperationStatusOperationId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkProperties _property;

        /// <summary>Properties of the virtual network resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.VirtualNetworkProperties()); set => this._property = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>
        /// Range of IP Addresses for Kubernetes API Server and services if using HA Proxy load balancer
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVipPoolItem> VipPool { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).VipPool; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).VipPool = value ?? null /* arrayOf */; }

        /// <summary>VLAN Id used by the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public int? VlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).VlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).VlanId = value ?? default(int); }

        /// <summary>Range of IP Addresses for Kubernetes node VMs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Origin(Microsoft.Azure.PowerShell.Cmdlets.AksArc.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVmipPoolItem> VmipPool { get => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).VmipPool; set => ((Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInternal)Property).VmipPool = value ?? null /* arrayOf */; }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }

        /// <summary>Creates an new <see cref="VirtualNetwork" /> instance.</summary>
        public VirtualNetwork()
        {

        }
    }
    /// The Virtual Network resource definition.
    public partial interface IVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResource
    {
        /// <summary>The error code from the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error code from the operation.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>List of DNS server IP Addresses associated with the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of DNS server IP Addresses associated with the network",
        SerializedName = @"dnsServers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> DnsServer { get; set; }
        /// <summary>ARM Id of the extended location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM Id of the extended location.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string ExtendedLocationName { get; set; }
        /// <summary>The extended location type. Allowed value: 'CustomLocation'</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The extended location type. Allowed value: 'CustomLocation'",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("CustomLocation")]
        string ExtendedLocationType { get; set; }
        /// <summary>IP Address of the Gateway associated with the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Address of the Gateway associated with the network",
        SerializedName = @"gateway",
        PossibleTypes = new [] { typeof(string) })]
        string Gateway { get; set; }
        /// <summary>Group in MOC(Microsoft On-premises Cloud)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Group in MOC(Microsoft On-premises Cloud)",
        SerializedName = @"mocGroup",
        PossibleTypes = new [] { typeof(string) })]
        string HciMocGroup { get; set; }
        /// <summary>Location in MOC(Microsoft On-premises Cloud)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Location in MOC(Microsoft On-premises Cloud)",
        SerializedName = @"mocLocation",
        PossibleTypes = new [] { typeof(string) })]
        string HciMocLocation { get; set; }
        /// <summary>Virtual Network name in MOC(Microsoft On-premises Cloud)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Virtual Network name in MOC(Microsoft On-premises Cloud)",
        SerializedName = @"mocVnetName",
        PossibleTypes = new [] { typeof(string) })]
        string HciMocVnetName { get; set; }
        /// <summary>IP Address Prefix of the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"IP Address Prefix of the network",
        SerializedName = @"ipAddressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddressPrefix { get; set; }
        /// <summary>The error message from the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The error message from the operation.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The status of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The status of the operation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string OperationStatus { get;  }
        /// <summary>The identifier of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identifier of the operation.",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string OperationStatusOperationId { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Pending", "Creating", "Deleting", "Updating", "Accepted")]
        string ProvisioningState { get;  }
        /// <summary>
        /// Range of IP Addresses for Kubernetes API Server and services if using HA Proxy load balancer
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Range of IP Addresses for Kubernetes API Server and services if using HA Proxy load balancer",
        SerializedName = @"vipPool",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVipPoolItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVipPoolItem> VipPool { get; set; }
        /// <summary>VLAN Id used by the network</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"VLAN Id used by the network",
        SerializedName = @"vlanID",
        PossibleTypes = new [] { typeof(int) })]
        int? VlanId { get; set; }
        /// <summary>Range of IP Addresses for Kubernetes node VMs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AksArc.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Range of IP Addresses for Kubernetes node VMs",
        SerializedName = @"vmipPool",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVmipPoolItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVmipPoolItem> VmipPool { get; set; }

    }
    /// The Virtual Network resource definition.
    internal partial interface IVirtualNetworkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.ITrackedResourceInternal
    {
        /// <summary>The error code from the operation.</summary>
        string Code { get; set; }
        /// <summary>List of DNS server IP Addresses associated with the network</summary>
        System.Collections.Generic.List<string> DnsServer { get; set; }
        /// <summary>Extended location pointing to the underlying infrastructure</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkExtendedLocation ExtendedLocation { get; set; }
        /// <summary>ARM Id of the extended location.</summary>
        string ExtendedLocationName { get; set; }
        /// <summary>The extended location type. Allowed value: 'CustomLocation'</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("CustomLocation")]
        string ExtendedLocationType { get; set; }
        /// <summary>IP Address of the Gateway associated with the network</summary>
        string Gateway { get; set; }
        /// <summary>Group in MOC(Microsoft On-premises Cloud)</summary>
        string HciMocGroup { get; set; }
        /// <summary>Location in MOC(Microsoft On-premises Cloud)</summary>
        string HciMocLocation { get; set; }
        /// <summary>Virtual Network name in MOC(Microsoft On-premises Cloud)</summary>
        string HciMocVnetName { get; set; }
        /// <summary>IP Address Prefix of the network</summary>
        string IPAddressPrefix { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInfraVnetProfile InfraVnetProfile { get; set; }
        /// <summary>Infrastructure network profile for HCI platform</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesInfraVnetProfileHci InfraVnetProfileHci { get; set; }
        /// <summary>The error message from the operation.</summary>
        string Message { get; set; }
        /// <summary>The status of the operation.</summary>
        string OperationStatus { get; set; }
        /// <summary>The error if any from the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesStatusOperationStatusError OperationStatusError { get; set; }
        /// <summary>The identifier of the operation.</summary>
        string OperationStatusOperationId { get; set; }
        /// <summary>Properties of the virtual network resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkProperties Property { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.AksArc.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Pending", "Creating", "Deleting", "Updating", "Accepted")]
        string ProvisioningState { get; set; }
        /// <summary>Status of the virtual network resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesStatus Status { get; set; }
        /// <summary>The detailed status of the long running operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesStatusOperationStatus StatusOperationStatus { get; set; }
        /// <summary>
        /// Range of IP Addresses for Kubernetes API Server and services if using HA Proxy load balancer
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVipPoolItem> VipPool { get; set; }
        /// <summary>VLAN Id used by the network</summary>
        int? VlanId { get; set; }
        /// <summary>Range of IP Addresses for Kubernetes node VMs</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.AksArc.Models.IVirtualNetworkPropertiesVmipPoolItem> VmipPool { get; set; }

    }
}