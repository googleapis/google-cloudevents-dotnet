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

using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Type
{
    /// <summary>
    /// An object representing a latitude/longitude pair.
    /// </summary>
    public sealed class LatLng
    {
        /// <summary>
        /// The latitude in degrees, in the range [-90.0, +90.0].
        /// </summary>
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude in degrees, in the range [-180.0, +180.0].
        /// </summary>
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}
