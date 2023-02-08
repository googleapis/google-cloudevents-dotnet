// Copyright 2023, Google LLC
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

namespace Google.Events.Protobuf.Cloud.Iot.V1
{    
    [global::CloudNative.CloudEvents.CloudEventFormatterAttribute(typeof(ProtobufJsonCloudEventFormatter<DeviceEventData>))]
    public partial class DeviceEventData
    {
        /// <summary>CloudEvent type for the 'CreateDevice' event.</summary>
        public const string CreateDeviceCloudEventType = "google.cloud.iot.v1.DeviceManager.CreateDevice";

        /// <summary>CloudEvent type for the 'UpdateDevice' event.</summary>
        public const string UpdateDeviceCloudEventType = "google.cloud.iot.v1.DeviceManager.UpdateDevice";

        /// <summary>CloudEvent type for the 'DeleteDevice' event.</summary>
        public const string DeleteDeviceCloudEventType = "google.cloud.iot.v1.DeviceManager.DeleteDevice";

    }
}
