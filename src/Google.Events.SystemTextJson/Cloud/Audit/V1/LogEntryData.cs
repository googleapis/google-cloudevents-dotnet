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

using Google.Events.SystemTextJson.Api;
using Google.Events.SystemTextJson.Rpc;
using Google.Events.SystemTextJson.Rpc.Context;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Cloud.Audit.V1
{
    /// <summary>
    /// Generic log entry, used as a wrapper for Cloud Audit Logs in events.
    /// This is copied from
    /// https://github.com/googleapis/googleapis/blob/master/google/logging/v2/log_entry.proto
    /// and adapted appropriately.
    /// </summary>
    public partial class LogEntryData
    {
        /// <summary>
        /// The resource name of the log to which this log entry belongs.
        /// </summary>
        [JsonPropertyName("logName")]
        public string? LogName { get; set; }

        /// <summary>
        /// The monitored resource that produced this log entry.
        ///
        /// Example: a log entry that reports a database error would be associated with
        /// the monitored resource designating the particular database that reported
        /// the error.
        /// </summary>
        [JsonPropertyName("resource")]
        public MonitoredResource? Resource { get; set; }

        /// <summary>
        /// The log entry payload, which is always an AuditLog for Cloud Audit Log events.
        /// </summary>
        [JsonPropertyName("protoPayload")]
        public AuditLog? ProtoPayload { get; set; }

        /// <summary>
        /// A unique identifier for the log entry. 
        /// </summary>
        [JsonPropertyName("insertId")]
        public string? InsertId { get; set; }

        /// <summary>
        /// A set of user-defined (key, value) data that provides additional
        /// information about the log entry.
        /// </summary>
        [JsonPropertyName("labels")]
        public IDictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Information about an operation associated with the log entry, if applicable.
        /// </summary>
        [JsonPropertyName("operation")]
        public LogEntryOperation? Operation { get; set; }

        /// <summary>
        /// The time the event described by the log entry occurred.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// The time the log entry was received by Logging.
        /// </summary>
        [JsonPropertyName("receiveTimestamp")]
        public DateTimeOffset? ReceiveTimestamp { get; set; }

        /// <summary>
        /// The severity of the log entry.
        /// </summary>
        [JsonPropertyName("severity")]
        public LogSeverity Severity { get; set; }

        /// <summary>
        /// Resource name of the trace associated with the log entry, if any. If it
        /// contains a relative resource name, the name is assumed to be relative to
        /// `//tracing.googleapis.com`. Example:
        /// `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
        /// </summary>
        [JsonPropertyName("trace")]
        public string? Trace { get; set; }

        /// <summary>
        /// The span ID within the trace associated with the log entry, if any.
        ///
        /// For Trace spans, this is the same format that the Trace API v2 uses: a
        /// 16-character hexadecimal encoding of an 8-byte array, such as
        /// `000000000000004a`.
        /// </summary>
        [JsonPropertyName("spanId")]
        public string? SpanId { get; set; }
    }

    /// <summary>
    /// Additional information about a potentially long-running operation with which
    /// a log entry is associated.
    /// </summary>
    public class LogEntryOperation
    {
        /// <summary>
        /// An arbitrary operation identifier. Log entries with the same
        /// identifier are assumed to be part of the same operation.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// An arbitrary producer identifier. The combination of `id` and
        /// `producer` must be globally unique. Examples for `producer`:
        /// `"MyDivision.MyBigCompany.com"`, `"github.com/MyProject/MyApplication"`.
        /// </summary>
        [JsonPropertyName("producer")]
        public string? Producer { get; set; }

        /// <summary>
        /// True if this is the first log entry in the operation.
        /// </summary>
        [JsonPropertyName("first")]
        public bool First { get; set; }

        /// <summary>
        /// True if this is the last log entry in the operation.
        /// </summary>
        [JsonPropertyName("last")]
        public bool Last { get; set; }
    }

    /// <summary>
    /// The severity of the event described in a log entry, expressed as one of the
    /// standard severity levels listed below.  For your reference, the levels are
    /// assigned the listed numeric values. The effect of using numeric values other
    /// than those listed is undefined.
    /// Copied from https://github.com/googleapis/googleapis/blob/master/google/logging/type/log_severity.proto
    /// </summary>
    public enum LogSeverity
    {
        /// <summary>
        /// (0) The log entry has no assigned severity level.
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// (100) Debug or trace information.
        /// </summary>
        DEBUG = 100,

        /// <summary>
        /// (200) Routine information, such as ongoing status or performance.
        /// </summary>
        INFO = 200,

        /// <summary>
        /// (300) Normal but significant events, such as start up, shut down, or
        /// a configuration change.
        /// </summary>
        NOTICE = 300,

        /// <summary>
        /// (400) Warning events might cause problems.
        /// </summary>
        WARNING = 400,

        /// <summary>
        /// (500) Error events are likely to cause problems.
        /// </summary>
        ERROR = 500,

        /// <summary>
        /// (600) Critical events cause more severe problems or outages.
        /// </summary>
        CRITICAL = 600,

        /// <summary>
        /// (700) A person must take an action immediately.
        /// </summary>
        ALERT = 700,

        /// <summary>
        /// (800) One or more systems are unusable.
        /// </summary>
        EMERGENCY = 800
    }

    /// <summary>
    /// Audit log event data.
    /// </summary>
    public sealed partial class AuditLog
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
        /// The resource location information.
        /// </summary>
        [JsonPropertyName("resourceLocation")]
        public ResourceLocation? ResourceLocation { get; set; }

        /// <summary>
        /// The resource's original state before mutation. Present only for
        /// operations which have successfully modified the targeted resource(s).
        /// In general, this field should contain all changed fields, except those
        /// that are already been included in `request`, `response`, `metadata` or
        /// `service_data` fields.
        /// When the JSON object represented here has a proto equivalent,
        /// the proto name will be indicated in the `@type` property.
        /// </summary>
        [JsonPropertyName("resourceOriginalState")]
        public JsonDocument? ResourceOriginalState { get; set; }

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
        /// information associated with the current audited event.
        /// </summary>
        [JsonPropertyName("metadata")]
        public JsonDocument? Metadata { get; set; }

        /// <summary>
        /// Deprecated, use `metadata` field instead.
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
        /// The email address of the authenticated user (or service account on behalf
        /// of third party principal) making the request. For privacy reasons, the
        /// principal email address is redacted for all read-only operations that fail
        /// with a "permission denied" error.
        /// </summary>
        [JsonPropertyName("principalEmail")]
        public string? PrincipalEmail { get; set; }

        /// <summary>
        /// The authority selector specified by the requestor, if any.
        /// It is not guaranteed that the principal was allowed to use this authority.
        /// </summary>
        [JsonPropertyName("authoritySelector")]
        public string? AuthoritySelector { get; set; }

        /// <summary>
        /// The third party identification (if any) of the authenticated user making
        /// the request.
        /// When the JSON object represented here has a proto equivalent, the proto
        /// name will be indicated in the `@type` property.
        /// </summary>
        [JsonPropertyName("thirdPartyPrincipal")]
        public JsonDocument? ThirdPartyPrincipal { get; set; }

        /// <summary>
        /// The name of the service account key used to create or exchange
        /// credentials for authenticating the service account making the request.
        /// This is a scheme-less URI full resource name. For example:
        ///
        /// "//iam.googleapis.com/projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}"
        /// </summary>
        [JsonPropertyName("serviceAccountKeyName")]
        public string? ServiceAccountKeyName { get; set; }

        /// <summary>
        /// Identity delegation history of an authenticated service account that makes
        /// the request. It contains information on the real authorities that try to
        /// access GCP resources by delegating on a service account. When multiple
        /// authorities present, they are guaranteed to be sorted based on the original
        /// ordering of the identity delegation events.
        /// </summary>
        [JsonPropertyName("serviceAccountDelegationInfo")]
        public IList<ServiceAccountDelegationInfo>? ServiceAccountDelegationInfo { get; set; }

        /// <summary>
        /// String representation of identity of requesting party.
        /// Populated for both first and third party identities.
        /// </summary>
        [JsonPropertyName("principalSubject")]
        public string? PrincipalSubject { get; set; }
    }

    /// <summary>
    /// Authorization information about the event.
    /// </summary>
    public sealed partial class AuthorizationInfo
    {
        /// <summary>
        /// The resource being accessed, as a REST-style string. For example:
        /// "bigquery.googleapis.com/projects/PROJECTID/datasets/DATASETID".
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

        /// <summary>
        /// Resource attributes used in IAM condition evaluation. This field contains
        /// resource attributes like resource type and resource name.
        ///
        /// To get the whole view of the attributes used in IAM
        /// condition evaluation, the user must also look into
        /// `AuditLogData.request_metadata.request_attributes`.
        /// </summary>
        [JsonPropertyName("resourceAttributes")]
        public Resource? ResourceAttributes { get; set; }
    }

    /// <summary>
    /// Metadata about the request.
    /// </summary>
    public sealed partial class RequestMetadata
    {
        /// <summary>
        /// The IP address of the caller.
        /// For caller from internet, this will be public IPv4 or IPv6 address.
        /// For caller from a Compute Engine VM with external IP address, this
        /// will be the VM's external IP address. For caller from a Compute
        /// Engine VM without external IP address, if the VM is in the same
        /// organization (or project) as the accessed resource, `caller_ip` will
        /// be the VM's internal IPv4 address, otherwise the `caller_ip` will be
        /// redacted to "gce-internal-ip".
        /// See https://cloud.google.com/compute/docs/vpc/ for more information.
        /// </summary>
        [JsonPropertyName("callerIp")]
        public string? CallerIp { get; set; }

        /// <summary>
        /// The user agent of the caller.
        /// This information is not authenticated and should be treated accordingly.
        /// </summary>
        [JsonPropertyName("callerSuppliedUserAgent")]
        public string? CallerSuppliedUserAgent { get; set; }

        /// <summary>
        /// The network of the caller.
        /// Set only if the network host project is part of the same GCP organization
        /// (or project) as the accessed resource.
        /// See https://cloud.google.com/compute/docs/vpc/ for more information.
        /// This is a scheme-less URI full resource name. For example:
        ///
        ///     "//compute.googleapis.com/projects/PROJECT_ID/global/networks/NETWORK_ID"
        /// </summary>
        [JsonPropertyName("callerNetwork")]
        public string? CallerNetwork { get; set; }

        /// <summary>
        /// Request attributes used in IAM condition evaluation. This field contains
        /// request attributes like request time and access levels associated with
        /// the request.
        ///
        ///
        /// To get the whole view of the attributes used in IAM
        /// condition evaluation, the user must also look into
        /// `AuditLog.authentication_info.resource_attributes`.
        /// </summary>
        [JsonPropertyName("requestAttributes")]
        public Request? RequestAttributes { get; set; }

        /// <summary>
        /// The destination of a network activity, such as accepting a TCP connection.
        /// In a multi hop network activity, the destination represents the receiver of
        /// the last hop. Only two fields are used in this message, Peer.port and
        /// Peer.ip. These fields are optionally populated by those services utilizing
        /// the IAM condition feature.
        /// </summary>
        [JsonPropertyName("destinationAttributes")]
        public Peer? DestinationAttributes { get; set; }
    }

    /// <summary>
    /// Location information about a resource.
    /// </summary>
    public class ResourceLocation
    {
        /// <summary>
        /// The locations of a resource after the execution of the operation.
        /// Requests to create or delete a location based resource must populate
        /// the 'current_locations' field and not the 'original_locations' field.
        /// For example:
        ///
        ///     "europe-west1-a"
        ///     "us-east1"
        ///     "nam3"
        /// </summary>
        [JsonPropertyName("currentLocations")]
        public IList<string>? CurrentLocations { get; set; }

        /// <summary>
        /// The locations of a resource prior to the execution of the operation.
        /// Requests that mutate the resource's location must populate both the
        /// 'original_locations' as well as the 'current_locations' fields.
        /// For example:
        ///
        ///     "europe-west1-a"
        ///     "us-east1"
        ///     "nam3"
        /// </summary>
        [JsonPropertyName("originalLocations")]
        public IList<string>? OriginalLocations { get; set; }
    }

    /// <summary>
    /// Identity delegation history of an authenticated service account.
    /// </summary>
    public class ServiceAccountDelegationInfo
    {
        private object? _authority;
        private int _authorityCase;

        private void SetValue(int @case, object? value) =>
            (_authorityCase, _authority) = (@case, value);

        /// <summary>
        /// First party (Google) identity as the real authority.
        /// </summary>
        [JsonPropertyName("firstPartyPrincipal")]
        public FirstPartyPrincipal? FirstPartyPrincipal
        {
            get => _authorityCase == 1 ? (FirstPartyPrincipal?) _authority : null;
            set => SetValue(4, value);
        }


        /// <summary>
        /// Third party identity as the real authority.
        /// </summary>
        [JsonPropertyName("thirdPartyPrincipal")]
        public ThirdPartyPrincipal? ThirdPartyPrincipal
        {
            get => _authorityCase == 2 ? (ThirdPartyPrincipal?) _authority : null;
            set => SetValue(2, value);
        }

        /// <summary>
        /// The "case" of the oneof for authority.
        /// </summary>
        [JsonIgnore]
        public int AuthorityCase => _authorityCase;
    }

    /// <summary>
    /// First party identity principal.
    /// </summary>
    public class FirstPartyPrincipal
    {
        /// <summary>
        /// The email address of a Google account.
        /// </summary>
        [JsonPropertyName("principalEmail")]
        public string? PrincipalEmail { get; set; }


        /// <summary>
        /// Metadata about the service that uses the service account.
        /// </summary>
        [JsonPropertyName("serviceMetadata")]
        public JsonDocument? ServiceMetadata { get; set; }
    }

    /// <summary>
    /// Third party identity principal.
    /// </summary>
    public class ThirdPartyPrincipal
    {
        /// <summary>
        /// Metadata about third party identity.
        /// </summary>
        [JsonPropertyName("thirdPartyClaims")]
        public JsonDocument? ThirdPartyClaims { get; set; }
    }
}
