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
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Firebase.Auth.V1
{
    /// <summary>
    /// The data within all Firebase Auth events
    /// </summary>
    public partial class AuthEventData
    {
        /// <summary>
        /// The user identifier in the Firebase app.
        /// </summary>
        [JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The user's primary email, if set.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Whether or not the user's primary email is verified.
        /// </summary>
        [JsonPropertyName("emailVerified")]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// The user's display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The user's photo URL.
        /// </summary>
        [JsonPropertyName("photoURL")]
        public string? PhotoURL { get; set; }

        /// <summary>
        /// Whether the user is disabled.
        /// </summary>
        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// Additional metadata about the user.
        /// </summary>
        [JsonPropertyName("metadata")]
        public UserMetadata? Metadata { get; set; }

        /// <summary>
        /// User's info at the providers
        /// </summary>
        [JsonPropertyName("providerData")]
        public IList<UserInfo>? ProviderData { get; set; }

        /// <summary>
        /// The user's phone number.
        /// </summary>
        [JsonPropertyName("phoneNumber")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// User's custom claims, typically used to define user roles and propagated
        /// to an authenticated user's ID token.
        /// </summary>
        [JsonPropertyName("customClaims")]
        public JsonDocument? CustomClaims { get; set; }
    }

    /// <summary>
    /// Additional metadata about the user.
    /// </summary>
    public class UserMetadata
    {
        /// <summary>
        /// The date the user was created.
        /// </summary>
        [JsonPropertyName("createdAt")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date the user last signed in.
        /// </summary>
        [JsonPropertyName("lastSignedInAt")]
        public DateTimeOffset? LastSignedInAt { get; set; }
    }

    /// <summary>
    /// User's info at the identity provider
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// The user identifier for the linked provider.
        /// </summary>
        [JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// The email for the linked provider.
        /// </summary>
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// The display name for the linked provider.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The photo URL for the linked provider.
        /// </summary>
        [JsonPropertyName("photoURL")]
        public string? PhotoURL { get; set; }

        /// <summary>
        /// The linked provider ID (e.g. "google.com" for the Google provider).
        /// </summary>
        [JsonPropertyName("providerId")] 
        public string? ProviderId { get; set; }
    }
}
