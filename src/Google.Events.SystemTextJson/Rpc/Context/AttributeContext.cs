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

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Rpc.Context
{
    /// <summary>
    /// This message defines attributes for a node that handles a network request.
    /// The node can be either a service or an application that sends, forwards,
    /// or receives the request. Service peers should fill in
    /// `principal` and `labels` as appropriate.
    /// </summary>
    public class Peer
    {
        /// <summary>
        /// The IP address of the peer.
        /// </summary>
        [JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// The network port of the peer.
        /// </summary>
        [JsonPropertyName("port")]
        public long Port { get; set; }


        /// <summary>
        /// The labels associated with the peer.
        /// </summary>
        [JsonPropertyName("labels")]
        public IDictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// The identity of this peer. Similar to `Request.auth.principal`, but
        /// relative to the peer instead of the request. For example, the
        /// idenity associated with a load balancer that forwared the request.
        /// </summary>
        [JsonPropertyName("principal")]
        public string? Principal { get; set; }

        /// <summary>
        /// The CLDR country/region code associated with the above IP address.
        /// If the IP address is private, the `region_code` should reflect the
        /// physical location where this peer is running.
        /// </summary>
        [JsonPropertyName("regionCode")]
        public string? RegionCode { get; set; }
    }

    /// <summary>
    /// This message defines request authentication attributes. Terminology is
    /// based on the JSON Web Token (JWT) standard, but the terms also
    /// correlate to concepts in other standards.
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// The authenticated principal. Reflects the issuer (`iss`) and subject
        /// (`sub`) claims within a JWT. The issuer and subject should be `/`
        /// delimited, with `/` percent-encoded within the subject fragment. For
        /// Google accounts, the principal format is:
        /// "https://accounts.google.com/{id}"
        /// </summary>
        [JsonPropertyName("principal")]
        public string? Principal { get; set; }

        /// <summary>
        /// The intended audience(s) for this authentication information. Reflects
        /// the audience (`aud`) claim within a JWT. The audience
        /// value(s) depends on the `issuer`, but typically include one or more of
        /// the following pieces of information:
        ///
        /// *  The services intended to receive the credential such as
        ///    ["pubsub.googleapis.com", "storage.googleapis.com"]
        /// *  A set of service-based scopes. For example,
        ///    ["https://www.googleapis.com/auth/cloud-platform"]
        /// *  The client id of an app, such as the Firebase project id for JWTs
        ///    from Firebase Auth.
        ///
        /// Consult the documentation for the credential issuer to determine the
        /// information provided.
        /// </summary>
        [JsonPropertyName("audiences")]
        public IList<string>? Audiences { get; set; }

        /// <summary>
        /// The authorized presenter of the credential. Reflects the optional
        /// Authorized Presenter (`azp`) claim within a JWT or the
        /// OAuth client id. For example, a Google Cloud Platform client id looks
        /// as follows: "123456789012.apps.googleusercontent.com".
        /// </summary>
        [JsonPropertyName("presenter")]
        public string? Presenter { get; set; }

        /// <summary>
        /// Structured claims presented with the credential. JWTs include
        /// `{key: value}` pairs for standard and private claims. The following
        /// is a subset of the standard required and optional claims that would
        /// typically be presented for a Google-based JWT:
        ///
        ///    {'iss': 'accounts.google.com',
        ///     'sub': '113289723416554971153',
        ///     'aud': ['123456789012', 'pubsub.googleapis.com'],
        ///     'azp': '123456789012.apps.googleusercontent.com',
        ///     'email': 'jsmith@example.com',
        ///     'iat': 1353601026,
        ///     'exp': 1353604926}
        ///
        /// SAML assertions are similarly specified, but with an identity provider
        /// dependent structure.
        /// </summary>
        [JsonPropertyName("claims")]
        public JsonDocument? Claims { get; set; }

        /// <summary>
        /// A list of access level resource names that allow resources to be
        /// accessed by authenticated requester. It is part of Secure GCP processing
        /// for the incoming request. An access level string has the format:
        /// "//{api_service_name}/accessPolicies/{policy_id}/accessLevels/{short_name}"
        ///
        /// Example:
        /// "//accesscontextmanager.googleapis.com/accessPolicies/MY_POLICY_ID/accessLevels/MY_LEVEL"
        /// </summary>
        [JsonPropertyName("accessLevels")]
        public IList<string>? AccessLevels { get; set; }
    }

    /// <summary>
    /// This message defines attributes for an HTTP request. If the actual
    /// request is not an HTTP request, the runtime system should try to map
    /// the actual request to an equivalent HTTP request.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// The unique ID for a request, which can be propagated to downstream
        /// systems. The ID should have low probability of collision
        /// within a single day for a specific service.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The HTTP request method, such as `GET`, `POST`.
        /// </summary>
        [JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// The HTTP request headers. If multiple headers share the same key, they
        /// must be merged according to the HTTP spec. All header keys must be
        /// lowercased, because HTTP header keys are case-insensitive.
        /// </summary>
        [JsonPropertyName("headers")]
        public IDictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The HTTP URL path.
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The HTTP request `Host` header value.
        /// </summary>
        [JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// The HTTP URL scheme, such as `http` and `https`.
        /// </summary>
        [JsonPropertyName("scheme")]
        public string? Scheme { get; set; }

        /// <summary>
        /// The HTTP URL query in the format of `name1=value1&amp;name2=value2`, as it
        /// appears in the first line of the HTTP request. No decoding is performed.
        /// </summary>
        [JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The timestamp when the `destination` service receives the first byte of
        /// the request.
        /// </summary>
        [JsonPropertyName("time")]
        public DateTimeOffset? Time { get; set; }

        /// <summary>
        /// The HTTP request size in bytes. If unknown, it must be -1.
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; set; }

        /// <summary>
        /// The network protocol used with the request, such as "http/1.1",
        /// "spdy/3", "h2", "h2c", "webrtc", "tcp", "udp", "quic". See
        /// https://www.iana.org/assignments/tls-extensiontype-values/tls-extensiontype-values.xhtml#alpn-protocol-ids
        /// for details.
        /// </summary>
        [JsonPropertyName("protocol")]
        public string? Protocol { get; set; }

        /// <summary>
        /// A special parameter for request reason. It is used by security systems
        /// to associate auditing information with a request.
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// The request authentication. May be absent for unauthenticated requests.
        /// Derived from the HTTP request `Authorization` header or equivalent.
        /// </summary>
        [JsonPropertyName("auth")]
        public Auth? Auth { get; set; }
    }

    /// <summary>
    /// This message defines core attributes for a resource. A resource is an
    /// addressable (named) entity provided by the destination service. For
    /// example, a file stored on a network storage service.
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// The name of the service that this resource belongs to, such as
        /// `pubsub.googleapis.com`. The service may be different from the DNS
        /// hostname that actually serves the request.
        /// </summary>
        [JsonPropertyName("service")]
        public string? Service { get; set; }

        /// <summary>
        /// The stable identifier (name) of a resource on the `service`. A resource
        /// can be logically identified as "//{resource.service}/{resource.name}".
        /// The differences between a resource name and a URI are:
        ///
        /// *   Resource name is a logical identifier, independent of network
        ///     protocol and API version. For example,
        ///     `//pubsub.googleapis.com/projects/123/topics/news-feed`.
        /// *   URI often includes protocol and version information, so it can
        ///     be used directly by applications. For example,
        ///     `https://pubsub.googleapis.com/v1/projects/123/topics/news-feed`.
        ///
        /// See https://cloud.google.com/apis/design/resource_names for details.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the resource. The syntax is platform-specific because
        /// different platforms define their resources differently.
        ///
        /// For Google APIs, the type format must be "{service}/{kind}".
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The labels or tags on the resource, such as AWS resource tags and
        /// Kubernetes resource labels.
        /// </summary>
        [JsonPropertyName("labels")]
        public IDictionary<string, string>? Labels { get; set; }
    }
}
