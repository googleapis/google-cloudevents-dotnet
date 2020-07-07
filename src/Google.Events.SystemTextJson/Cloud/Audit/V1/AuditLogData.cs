// Copyright 2020, Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#nullable enable

using Google.Events.SystemTextJson.Rpc;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Cloud.Audit.V1
{
    /// <summary>
    /// Audit log event data.
    /// </summary>
    public sealed partial class AuditLogData
    {
        /// <summary>
        /// The name of the API service performing the operation. For example,
        /// "datastore.googleapis.com".
        /// </summary>
        [JsonPropertyName("serviceName")]
        public string? ServiceName { get; set; }

        /// <summary>
        /// The name of the service method or operation.
        /// For API calls, this should be the name of the API method.
        /// For example, "google.datastore.v1.Datastore.RunQuery",
        /// "google.logging.v1.LoggingService.DeleteLog".
        /// </summary>
        [JsonPropertyName("methodName")]
        public string? MethodName { get; set; }

        /// <summary>
        /// The resource or collection that is the target of the operation.
        /// The name is a scheme-less URI, not including the API service name.
        /// For example: "shelves/SHELF_ID/books", "shelves/SHELF_ID/books/BOOK_ID".
        /// </summary>
        [JsonPropertyName("resourceName")]
        public string? ResourceName { get; set; }

        /// <summary>
        /// The number of items returned from a List or Query API method,
        /// if applicable.
        /// </summary>
        [JsonPropertyName("numResponseItems")]
        public long NumResponseItems { get; set; }

        /// <summary>
        /// The status of the overall operation.
        /// </summary>
        [JsonPropertyName("status")]
        public Status? Status { get; }

        /// <summary>
        /// Authentication information.
        /// </summary>
        [JsonPropertyName("authenticationInfo")]
        public AuthenticationInfo? AuthenticationInfo { get; set; }

        /// <summary>
        /// Authorization information. If there are multiple
        /// resources or permissions involved, then there is
        /// one AuthorizationInfo element for each {resource, permission} tuple.
        /// </summary>
        [JsonPropertyName("authorizationInfo")]
        public List<AuthorizationInfo> AuthorizationInfo { get; set; } = new List<AuthorizationInfo>();

        /// <summary>
        /// Metadata about the operation.
        /// </summary>
        [JsonPropertyName("requestMetadata")]
        public RequestMetadata? RequestMetadata { get; set; }

        /// <summary>
        /// The operation request. This may not include all request parameters,
        /// such as those that are too large, privacy-sensitive, or duplicated
        /// elsewhere in the log record.
        /// It should never include user-generated data, such as file contents.
        /// When the JSON object represented here has a proto equivalent, the proto
        /// name will be indicated in the `@type` property.
        /// </summary>
        [JsonPropertyName("request")]
        public JsonDocument? Request { get; set; }

        /// <summary>
        /// The operation response. This may not include all response parameters,
        /// such as those that are too large, privacy-sensitive, or duplicated
        /// elsewhere in the log record.
        /// It should never include user-generated data, such as file contents.
        /// When the JSON object represented here has a proto equivalent, the proto
        /// name will be indicated in the `@type` property.
        /// </summary>
        [JsonPropertyName("response")]
        public JsonDocument? Response { get; set; }

        /// <summary>
        /// Other service-specific data about the request, response, and other
        /// activities.
        /// When the JSON object represented here has a proto equivalent, the proto
        /// name will be indicated in the `@type` property.
        /// </summary>
        [JsonPropertyName("serviceData")]
        public JsonDocument? ServiceData { get; set; }
    }

    /// <summary>
    /// Authentication information for the operation.
    /// </summary>
    public sealed partial class AuthenticationInfo
    {
        /// <summary>
        /// The email address of the authenticated user making the request.
        /// </summary>
        [JsonPropertyName("principalEmail")]
        public string? PrincipalEmail { get; set; }
    }

    /// <summary>
    /// Authorization information about the event.
    /// </summary>
    public sealed partial class AuthorizationInfo
    {
        /// <summary>
        /// The resource being accessed, as a REST-style string. For example:
        /// "bigquery.googlapis.com/projects/PROJECTID/datasets/DATASETID".
        /// </summary>
        [JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        /// The required IAM permission.
        /// </summary>
        [JsonPropertyName("permission")]
        public string? Permission { get; set; }

        /// <summary>
        /// Whether or not authorization for <see cref="Resource"/>
        /// and <see cref="Permission"/> was granted.
        /// </summary>
        [JsonPropertyName("granted")]
        public bool Granted { get; set; }
    }

    /// <summary>
    /// Metadata about the request.
    /// </summary>
    public sealed partial class RequestMetadata
    {
        /// <summary>
        /// The IP address of the caller.
        /// </summary>
        [JsonPropertyName("callerIp")]
        public string? CallerIp { get; set; }

        /// <summary>
        /// The user agent of the caller.
        /// This information is not authenticated and should be treated accordingly.
        /// </summary>
        [JsonPropertyName("callerSuppliedUserAgent")]
        public string? CallerSuppliedUserAgent { get; set; }
    }
}
