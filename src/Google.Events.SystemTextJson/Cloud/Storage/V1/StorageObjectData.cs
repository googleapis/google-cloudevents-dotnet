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

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Cloud.Storage.V1
{
    /// <summary>
    /// The CloudEvent representation of a storage message as translated from a GCF event.
    /// </summary>
    public sealed partial class StorageObjectData
    {
        /// <summary>
        /// The ID of the object, including the bucket name, object name, and generation number.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The link to this object.
        /// </summary>
        [JsonPropertyName("selfLink")]
        public string? SelfLink { get; set; }

        /// <summary>
        /// The kind of item this is. For objects, this is always "storage#object".
        /// </summary>
        [JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// The name of the object.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The name of the bucket containing this object.
        /// </summary>
        [JsonPropertyName("bucket")]
        public string? Bucket { get; set; }

        /// <summary>
        /// The content generation of this object. Used for object versioning.
        /// </summary>
        [JsonPropertyName("generation")]
        [JsonConverter(typeof(NullableInt64FromStringConverter))]
        public long? Generation { get; set; }

        /// <summary>
        /// The version of the metadata for this object at this generation.
        /// Used for preconditions and for detecting changes in metadata.
        /// A metageneration number is only meaningful in the context of a
        /// particular generation of a particular object.
        /// </summary>
        [JsonPropertyName("metageneration")]
        [JsonConverter(typeof(NullableInt64FromStringConverter))]
        public long? Metageneration { get; set; }

        /// <summary>
        /// Content-Type of the object data. If an object is stored without a Content-Type,
        /// it is served as application/octet-stream.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }

        /// <summary>
        /// The creation time of the object.
        /// </summary>
        [JsonPropertyName("timeCreated")]
        public DateTimeOffset? TimeCreated { get; set; }

        /// <summary>
        /// The modification time of the object metadata.
        /// </summary>
        [JsonPropertyName("updated")]
        public DateTimeOffset? Updated { get; set; }

        /// <summary>
        /// The deletion time of the object. Returned if and only if this version of the object is no longer
        /// a live version, but remains in the bucket as a noncurrent version.
        /// </summary>
        [JsonPropertyName("timeDeleted")]
        public DateTimeOffset? TimeDeleted { get; set; }

        /// <summary>
        /// Whether or not the object is subject to a temporary hold.
        /// </summary>
        [JsonPropertyName("temporaryHold")]
        public bool? TemporaryHold { get; set; }

        /// <summary>
        /// Whether or not the object is subject to an event-based hold.
        /// </summary>
        [JsonPropertyName("eventBasedHold")]
        public bool? EventBasedHold { get; set; }

        /// <summary>
        /// The earliest time that the object can be deleted, based on a bucket's retention policy.
        /// </summary>
        [JsonPropertyName("retentionExpirationTime")]
        public DateTimeOffset? RetentionExpirationTime { get; set; }

        /// <summary>
        /// Storage class of the object.
        /// </summary>
        [JsonPropertyName("storageClass")]
        public string? StorageClass { get; set; }

        /// <summary>
        /// The time at which the object's storage class was last changed.
        /// When the object is initially created, it will be set to <see cref="TimeCreated"/>.
        /// </summary>
        [JsonPropertyName("timeStorageClassUpdated")]
        public DateTimeOffset? TimeStorageClassUpdated { get; set; }

        /// <summary>
        /// Content-Length of the data in bytes.
        /// </summary>
        [JsonPropertyName("size")]
        [JsonConverter(typeof(NullableUInt64FromStringConverter))]
        public ulong? Size { get; set; }

        /// <summary>
        /// MD5 hash of the data; encoded using base64.
        /// </summary>
        [JsonPropertyName("md5Hash")]
        public string? Md5Hash { get; set; }

        /// <summary>
        /// Media download link.
        /// </summary>
        [JsonPropertyName("mediaLink")]
        public string? MediaLink { get; set; }

        /// <summary>
        /// Content-Encoding of the object data.
        /// </summary>
        [JsonPropertyName("contentEncoding")]
        public string? ContentEncoding { get; set; }

        /// <summary>
        /// Content-Disposition of the object data.
        /// </summary>
        [JsonPropertyName("contentDisposition")]
        public string? ContentDisposition { get; set; }

        /// <summary>
        /// Content-Language of the object data.
        /// </summary>
        [JsonPropertyName("contentLanguage")]
        public string? ContentLanguage { get; set; }

        /// <summary>
        /// Cache-Control directive for the object data. If omitted, and the object is accessible to all anonymous users, the default will be public, max-age=3600.
        /// </summary>
        [JsonPropertyName("cacheControl")]
        public string? CacheControl { get; set; }

        /// <summary>
        /// User-provided metadata, in key/value pairs.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IDictionary<string, object>? Metadata { get; set; }

        /// <summary>
        /// CRC32c checksum, as described in RFC 4960, Appendix B; encoded using base64 in big-endian byte order.
        /// </summary>
        [JsonPropertyName("crc32c")]
        public string? Crc32C { get; set; }

        /// <summary>
        /// Number of underlying components that make up a composite object.
        /// </summary>
        [JsonPropertyName("componentCount")]
        public int? ComponentCount { get; set; }

        /// <summary>
        /// HTTP 1.1 Entity tag for the object.
        /// </summary>
        [JsonPropertyName("etag")]
        public string? Etag { get; set; }

        /// <summary>
        /// Metadata of customer-supplied encryption key, if the object is encrypted by such a key.
        /// </summary>
        [JsonPropertyName("customerEncryption")]
        public CustomerEncryption? CustomerEncryption { get; set; }

        /// <summary>
        /// Cloud KMS Key used to encrypt this object, if the object is encrypted by such a key.
        /// </summary>
        [JsonPropertyName("kmsKeyName")]
        public string? KmsKeyName { get; set; }
    }

    /// <summary>
    /// Details of the customer encryption in a <see cref="StorageObjectData"/>.
    /// </summary>
    public sealed class CustomerEncryption
    {
        /// <summary>
        /// The encryption algorithm.
        /// </summary>
        [JsonPropertyName("encryptionAlgorithm")]
        public string? EncryptionAlgorithm { get; set; }

        /// <summary>
        /// SHA256 hash value of the encryption key.
        /// </summary>
        [JsonPropertyName("keySha256")]
        public string? KeySha256 { get; set; }
    }

}
