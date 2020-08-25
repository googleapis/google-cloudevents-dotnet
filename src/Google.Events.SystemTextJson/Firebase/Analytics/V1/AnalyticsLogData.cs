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

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Google.Events.SystemTextJson.Firebase.Analytics.V1
{
    /// <summary>
    /// The data within Firebase Analytics log events.
    /// </summary>
    public partial class AnalyticsLogData
    {
        /// <summary>
        /// User related dimensions.
        /// </summary>
        [JsonPropertyName("userDim")]
        public UserDimensions? UserDim { get; set; }

        /// <summary>
        /// A repeated record of event related dimensions.
        /// </summary>
        [JsonPropertyName("eventDim")]
        public IList<EventDimensions>? EventDim { get; set; }
    }

    /// <summary>
    /// Message containing information about the user associated with the event.
    /// </summary>
    public class UserDimensions
    {
        /// <summary>
        /// The user ID set via the setUserId API.
        /// </summary>
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The time (in microseconds) at which the user first opened the app.
        /// </summary>
        [JsonPropertyName("firstOpenTimestampMicros")]
        public long FirstOpenTimestampMicros { get; set; }

        /// <summary>
        /// A repeated record of user properties set with the setUserProperty API.
        /// https://firebase.google.com/docs/analytics/android/properties
        /// </summary>
        [JsonPropertyName("userProperties")]
        public IDictionary<string, UserPropertyValue>? UserProperties { get; set; }

        /// <summary>
        /// Device information.
        /// </summary>
        [JsonPropertyName("deviceInfo")]
        public DeviceInfo? DeviceInfo { get; set; }

        /// <summary>
        /// User's geographic information.
        /// </summary>
        [JsonPropertyName("geoInfo")]
        public GeoInfo? GeoInfo { get; set; }

        /// <summary>
        /// App information.
        /// </summary>
        [JsonPropertyName("appInfo")]
        public AppInfo? AppInfo { get; set; }

        /// <summary>
        /// Information about marketing campaign which acquired the user.
        /// </summary>
        [JsonPropertyName("trafficSource")]
        public TrafficSource? TrafficSource { get; set; }

        /// <summary>
        /// Information regarding the bundle in which these events were uploaded.
        /// </summary>
        [JsonPropertyName("bundleInfo")]
        public ExportBundleInfo? BundleInfo { get; set; }

        /// <summary>
        /// Lifetime Value information about this user.
        /// </summary>
        [JsonPropertyName("ltvInfo")]
        public LtvInfo? LtvInfo { get; set; }
    }

    /// <summary>
    /// Predefined (eg: LTV) or custom properties (eg: birthday) stored on client
    /// side and associated with subsequent HitBundles.
    /// </summary>
    public class UserPropertyValue
    {
        /// <summary>
        /// Last set value of user property.
        /// </summary>
        [JsonPropertyName("value")]
        public AnalyticsValue? Value { get; set; }

        /// <summary>
        /// UTC client time when user property was last set.
        /// </summary>
        [JsonPropertyName("setTimestampUsec")]
        public long SetTimestampUsec { get; set; }

        /// <summary>
        /// Index for user property (one-based).
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; }
    }

    /// <summary>
    /// Value for Event Params and UserProperty can be of type string or int or
    /// float or double.
    /// </summary>
    public class AnalyticsValue
    {
        private object? _paramValue;
        private int _paramCase;

        private void SetValue(int @case, object? value) =>
            (_paramCase, _paramValue) = (@case, value);

        /// <summary>
        /// String value for the parameter
        /// </summary>
        [JsonPropertyName("stringValue")]
        public string? StringValue
        {
            get => _paramCase == 1 ? (string?) _paramValue : null;
            set => SetValue(1, value);
        }

        /// <summary>
        /// Integer value for the parameter
        /// </summary>
        [JsonPropertyName("intValue")]
        public long IntValue
        {
            get => _paramCase == 2 ? (long) _paramValue! : 0L;
            set => SetValue(2, value);
        }

        /// <summary>
        /// 32-bit floating point value for the parameter
        /// </summary>
        [JsonPropertyName("floatValue")]
        public float FloatValue
        {
            get => _paramCase == 3 ? (float) _paramValue! : 0f;
            set => SetValue(3, value);
        }

        /// <summary>
        /// 64-bit floating point value for the parameter
        /// </summary>
        [JsonPropertyName("doubleValue")]
        public double DoubleValue
        {
            get => _paramCase == 4 ? (double) _paramValue! : 0d;
            set => SetValue(4, value);
        }

        /// <summary>
        /// The "case" of the parameter.
        /// </summary>        
        [JsonIgnore]
        public int ParamValueCase => _paramCase;
    }

    /// <summary>
    /// Message containing device informations.
    /// </summary>
    public class DeviceInfo
    {
        /// <summary>
        /// Device category.
        /// Eg. tablet or mobile.
        /// </summary>
        [JsonPropertyName("deviceCategory")]
        public string? DeviceCategory { get; set; }

        /// <summary>
        /// Device brand name.
        /// Eg. Samsung, HTC, etc.
        /// </summary>
        [JsonPropertyName("mobileBrandName")]
        public string? MobileBrandName { get; set; }

        /// <summary>
        /// Device model name.
        /// Eg. GT-I9192
        /// </summary>
        [JsonPropertyName("mobileModelName")]
        public string? MobileModelName { get; set; }

        /// <summary>
        /// Device marketing name.
        /// Eg. Galaxy S4 Mini
        /// </summary>
        [JsonPropertyName("mobileMarketingName")]
        public string? MobileMarketingName { get; set; }

        /// <summary>
        /// Device model.
        /// Eg. GT-I9192
        /// </summary>
        [JsonPropertyName("deviceModel")]
        public string? DeviceModel { get; set; }

        /// <summary>
        /// Device OS version when data capture ended.
        /// Eg. 4.4.2
        /// </summary>
        [JsonPropertyName("platformVersion")]
        public string? PlatformVersion { get; set; }

        /// <summary>
        /// Vendor specific device identifier. This is IDFV on iOS. Not used for
        /// Android.
        /// Example: "599F9C00-92DC-4B5C-9464-7971F01F8370"
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string? DeviceId { get; set; }

        /// <summary>
        /// The type of the resettable_device_id is always IDFA on iOS and AdId
        /// on Android.
        /// Example: "71683BF9-FA3B-4B0D-9535-A1F05188BAF3"
        /// </summary>
        [JsonPropertyName("resettableDeviceId")]
        public string? ResettableDeviceId { get; set; }

        /// <summary>
        /// The user language.
        /// Eg. "en-us", "en-za", "zh-tw", "jp"
        /// </summary>
        [JsonPropertyName("userDefaultLanguage")]
        public string? UserDefaultLanguage { get; set; }

        /// <summary>
        /// The timezone of the device when data was uploaded as seconds skew from UTC.
        /// </summary>
        [JsonPropertyName("deviceTimeZoneOffsetSeconds")]
        public int DeviceTimeZoneOffsetSeconds { get; set; }

        /// <summary>
        /// The device's Limit Ad Tracking setting.
        /// When true, we cannot use device_id for remarketing, demographics or
        /// influencing ads serving behaviour. However, we can use device_id for
        /// conversion tracking and campaign attribution.
        /// </summary>
        [JsonPropertyName("limitedAdTracking")]
        public bool LimitedAdTracking { get; set; }
    }

    /// <summary>
    /// Message which contains App Information.
    /// </summary>
    public class AppInfo
    {
        /// <summary>
        /// The app's version name
        /// Examples: "1.0", "4.3.1.1.213361", "2.3 (1824253)", "v1.8b22p6"
        /// </summary>
        [JsonPropertyName("appVersion")]
        public string? AppVersion { get; set; }

        /// <summary>
        /// Unique id for this instance of the app.
        /// Example: "71683BF9FA3B4B0D9535A1F05188BAF3"
        /// </summary>
        [JsonPropertyName("appInstanceId")]
        public string? AppInstanceId { get; set; }

        /// <summary>
        /// The identifier of the store that installed the app.
        /// Eg. "com.sec.android.app.samsungapps", "com.amazon.venezia",
        /// "com.nokia.nstore"
        /// </summary>
        [JsonPropertyName("appStore")]
        public string? AppStore { get; set; }

        /// <summary>
        /// The app platform.
        /// Eg "ANDROID", "IOS".
        /// </summary>
        [JsonPropertyName("appPlatform")]
        public string? AppPlatform { get; set; }

        /// <summary>
        /// Unique application identifier within an app store.
        /// </summary>
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
    }

    /// <summary>
    /// User's geographic informaiton.
    /// </summary>
    public class GeoInfo
    {
        /// <summary>
        /// The geographic continent.
        /// Eg. Americas
        /// </summary>
        [JsonPropertyName("continent")]
        public string? Continent { get; set; }

        /// <summary>
        /// The geographic country.
        /// Eg. Brazil
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The geographic region.
        /// Eg. State of Sao Paulo
        /// </summary>
        [JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The geographic city.
        /// Eg. Sao Paulo
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }
    }



    /// <summary>
    /// Message containing marketing campaign information which acquired the user.
    /// </summary>
    public class TrafficSource
    {
        /// <summary>
        /// The name of the campaign which acquired the user. 
        /// </summary>
        [JsonPropertyName("userAcquiredCampaign")]
        public string? UserAcquiredCampaign { get; set; }

        /// <summary>
        /// The name of the network which acquired the user.
        /// </summary>
        [JsonPropertyName("userAcquiredSource")]
        public string? UserAcquiredSource { get; set; }

        /// <summary>
        /// The name of the medium which acquired the user.
        /// </summary>
        [JsonPropertyName("userAcquiredMedium")]
        public string? UserAcquiredMedium { get; set; }
    }


    /// <summary>
    /// Message containing information regarding the bundle in which these
    /// events were uploaded.
    /// </summary>
    public class ExportBundleInfo
    {
        /// <summary>
        /// Monotonically increasing index for each bundle set by SDK.
        /// </summary>
        [JsonPropertyName("bundleSequenceId")]
        public int BundleSequenceId { get; set; }

        /// <summary>
        /// Timestamp offset between collection time and upload time.
        /// </summary>
        [JsonPropertyName("serverTimestampOffsetMicros")]
        public long ServerTimestampOffsetMicros { get; set; }
    }

    /// <summary>
    /// Lifetime Value information about this user.
    /// </summary>
    public class LtvInfo
    {
        /// <summary>
        /// The Lifetime Value revenue of this user.
        /// </summary>
        [JsonPropertyName("revenue")]
        public double Revenue { get; set; }

        /// <summary>
        /// The currency corresponding to the revenue.
        /// </summary>
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
    }

    /// <summary>
    /// Message containing information pertaining to the event.
    /// </summary>
    public class EventDimensions
    {
        /// <summary>
        /// The date on which this event was logged.
        /// (YYYYMMDD format in the registered timezone of your app.)
        /// </summary>
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// The name of this event.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A repeated record of the parameters associated with this event.
        /// </summary>
        [JsonPropertyName("params")]
        public IDictionary<string, AnalyticsValue>? Params { get; set; }

        /// <summary>
        /// UTC client time when the event happened.
        /// </summary>
        [JsonPropertyName("timestampMicros")]
        public long TimestampMicros { get; set; }

        /// <summary>
        /// UTC client time when the previous event happened.
        /// </summary>
        [JsonPropertyName("previousTimestampMicros")]
        public long PreviousTimestampMicros { get; set; }

        /// <summary>
        /// Value param in USD.
        /// </summary>
        [JsonPropertyName("valueInUsd")]
        public double ValueInUsd { get; set; }
    }
}
