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

namespace Google.Events.SystemTextJson.Rpc
{
    /// <summary>
    /// 
    /// </summary>
    public enum Code
    {
        /// <summary>
        /// Not an error; returned on success.
        /// HTTP Mapping: 200 OK
        /// </summary>
        OK = 0,

        /// <summary>
        /// The operation was cancelled, typically by the caller.
        /// HTTP Mapping: 499 Client Closed Request
        /// </summary>
        Cancelled = 1,

        /// <summary>
        /// Unknown error.  For example, this error may be returned when
        /// a <see cref="Status"/> value received from another address space belongs to
        /// an error space that is not known in this address space.  Also
        /// errors raised by APIs that do not return enough error information
        /// may be converted to this error.
        /// HTTP Mapping: 500 Internal Server Error.
        /// </summary>
        Unknown = 2,

        /// <summary>
        /// The client specified an invalid argument.  Note that this differs
        /// from `FAILED_PRECONDITION`.  `INVALID_ARGUMENT` indicates arguments
        /// that are problematic regardless of the state of the system
        /// (e.g., a malformed file name).
        ///  HTTP Mapping: 400 Bad Request
        /// </summary>
        InvalidArgument = 3,

        /// <summary>
        /// The deadline expired before the operation could complete. For operations
        /// that change the state of the system, this error may be returned
        /// even if the operation has completed successfully.  For example, a
        /// successful response from a server could have been delayed long
        /// enough for the deadline to expire.
        /// HTTP Mapping: 504 Gateway Timeout
        /// </summary>
        DeadlineExceeded = 4,

        /// <summary>
        /// Some requested entity (e.g., file or directory) was not found.
        /// HTTP Mapping: 404 Not Found
        /// </summary>
        NotFound = 5,

        /// <summary>
        /// The entity that a client attempted to create (e.g., file or directory) already exists.
        /// HTTP Mapping: 409 Conflict
        /// </summary>
        AlreadyExists = 6,

        /// <summary>
        /// The caller does not have permission to execute the specified
        /// operation. This error code does not imply the
        /// request is valid or the requested entity exists or satisfies
        /// other pre-conditions.
        /// HTTP Mapping: 403 Forbidden
        /// </summary>
        PermissionDenied = 7,

        /// <summary>
        /// Some resource has been exhausted, perhaps a per-user quota, or
        /// perhaps the entire file system is out of space.
        /// HTTP Mapping: 429 Too Many Requests
        /// </summary>
        ResourceExhausted = 8,

        /// <summary>
        /// The operation was rejected because the system is not in a state
        /// required for the operation's execution.  For example, the directory
        /// to be deleted is non-empty, an rmdir operation is applied to
        /// a non-directory, etc.
        /// HTTP Mapping: 400 Bad Request
        /// </summary>
        FailedPrecondition = 9,

        /// <summary>
        /// The operation was aborted, typically due to a concurrency issue such as
        /// a sequencer check failure or transaction abort.
        /// HTTP Mapping: 409 Conflict
        /// </summary>
        Aborted = 10,

        /// <summary>
        /// <para>
        /// The operation was attempted past the valid range, e.g. seeking or
        /// reading past end-of-file.
        /// </para>
        /// <para>
        /// Unlike <see cref="InvalidArgument"/>, this error indicates a problem that may
        /// be fixed if the system state changes. For example, a 32-bit file
        /// system will generate <see cref="InvalidArgument"/> if asked to read at an
        /// offset that is not in the range 0 to 2^32-1, but it will generate
        /// <see cref="OutOfRange"/> if asked to read from an offset past the current
        /// file size.
        /// </para>
        /// </summary>
        OutOfRange = 11,

        /// <summary>
        /// The operation is not implemented or is not supported/enabled in this service.
        /// HTTP Mapping: 501 Not Implemented
        /// </summary>
        Unimplemented = 12,

        /// <summary>
        /// Internal errors.  This means that some invariants expected by the
        /// underlying system have been broken.  This error code is reserved
        /// for serious errors.
        /// HTTP Mapping: 500 Internal Server Error
        /// </summary>
        Internal = 13,

        /// <summary>
        /// The service is currently unavailable.  This is most likely a
        /// transient condition, which can be corrected by retrying with
        /// a backoff. Note that it is not always safe to retry
        /// non-idempotent operations.
        /// HTTP Mapping: 503 Service Unavailable
        /// </summary>
        Unavailable = 14,

        /// <summary>
        /// Unrecoverable data loss or corruption.
        /// HTTP Mapping: 500 Internal Server Error
        /// </summary>
        DataLoss = 15,

        /// <summary>
        /// The request does not have valid authentication credentials for the operation.
        /// HTTP Mapping: 401 Unauthorized
        /// </summary>
        Unauthenticated = 16
    }
}
