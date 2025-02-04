// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure ML Studio Web Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureML")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMLLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureMLLinkedService class.
        /// </summary>
        public AzureMLLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMLLinkedService class.
        /// </summary>
        /// <param name="mlEndpoint">The Batch Execution REST URL for an Azure
        /// ML Studio Web Service endpoint. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="apiKey">The API key for accessing the Azure ML model
        /// endpoint.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the linked service.</param>
        /// <param name="updateResourceEndpoint">The Update Resource REST URL
        /// for an Azure ML Studio Web Service endpoint. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="servicePrincipalId">The ID of the service principal
        /// used to authenticate against the ARM-based updateResourceEndpoint
        /// of an Azure ML Studio web service. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="servicePrincipalKey">The key of the service principal
        /// used to authenticate against the ARM-based updateResourceEndpoint
        /// of an Azure ML Studio web service.</param>
        /// <param name="tenant">The name or ID of the tenant to which the
        /// service principal belongs. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string.</param>
        /// <param name="authentication">Type of authentication (Required to
        /// specify MSI) used to connect to AzureML. Type: string (or
        /// Expression with resultType string).</param>
        public AzureMLLinkedService(object mlEndpoint, SecretBase apiKey, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object updateResourceEndpoint = default(object), object servicePrincipalId = default(object), SecretBase servicePrincipalKey = default(SecretBase), object tenant = default(object), string encryptedCredential = default(string), object authentication = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            MlEndpoint = mlEndpoint;
            ApiKey = apiKey;
            UpdateResourceEndpoint = updateResourceEndpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Tenant = tenant;
            EncryptedCredential = encryptedCredential;
            Authentication = authentication;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Batch Execution REST URL for an Azure ML Studio
        /// Web Service endpoint. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlEndpoint")]
        public object MlEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the API key for accessing the Azure ML model endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.apiKey")]
        public SecretBase ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the Update Resource REST URL for an Azure ML Studio
        /// Web Service endpoint. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.updateResourceEndpoint")]
        public object UpdateResourceEndpoint { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against the ARM-based updateResourceEndpoint of an Azure ML Studio
        /// web service. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against the ARM-based updateResourceEndpoint of an Azure ML Studio
        /// web service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets type of authentication (Required to specify MSI) used
        /// to connect to AzureML. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authentication")]
        public object Authentication { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MlEndpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MlEndpoint");
            }
            if (ApiKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApiKey");
            }
        }
    }
}
